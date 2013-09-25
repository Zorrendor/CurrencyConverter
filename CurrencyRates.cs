using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Globalization;


namespace СurrencyConverter
{
    public class CurrencyRates
    {
        /// <summary>
        /// Дата внесённых изменений курса валют.
        /// </summary>
        public DateTime Date { get; set; }   
        /// <summary>
        /// Название валюты - ключ, курс - значение.
        /// </summary>
               
        public Dictionary<string, double> Currency { get; set; }
        public CurrencyRates()
        {
            Currency = new Dictionary<string, double>();
        }
        /// <summary>
        /// Добавление нового курса валюты.
        /// </summary>
        public void AddCurrency(string cur, double rate)
        {
            Currency.Add(cur, rate);
        }

        /// <summary>
        /// Загрузка из xml файла.
        /// </summary>
        public static void LoadXmlFile()
        {
            string fileName = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
            XDocument xml = XDocument.Load(fileName);
            XElement rootForCurrency = new XElement(xml.Root.Elements().Last());
            int i = 0;

            foreach (XElement el in rootForCurrency.Elements())
            {
                CurrencyRatesData.currencyRates.Add(new CurrencyRates());
                CurrencyRatesData.currencyRates[i].Date = DateTime.Parse(el.Attribute("time").Value);
                foreach (XElement cur in el.Elements())
                {
                    //currencyRates[i].Currency.Add(cur.Attribute("currency").Value, double.Parse(cur.Attribute("rate").Value, CultureInfo.GetCultureInfo("en-US")));
                    CurrencyRatesData.currencyRates[i].AddCurrency(cur.Attribute("currency").Value, double.Parse(cur.Attribute("rate").Value, CultureInfo.GetCultureInfo("en-US")));
                }
                i++;
            }
        }

        /// <summary>
        /// Запись данных в файл.
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="indexToDate">Индекс конечной даты</param>
        /// <param name="indexFromDate">Индекс начальной даты</param>
        /// <param name="currency">Выбранная валюта</param>
        public static void WriteInFile(string fileName, int indexToDate, int indexFromDate, string currency)
        {
            StreamWriter file = new StreamWriter(fileName);
            file.Write("Currency\\Date;");
            for (int i = indexToDate; i <= indexFromDate; i++)
            {
                //file.Write(cube[i].Date.ToString("dd.MM.yyyy") + ";");
                file.Write(CurrencyRatesData.currencyRates[i].Date.ToString("yyyy.MM.dd") + ";");
            }
            if (currency == "All")
            {
                foreach (KeyValuePair<string, double> pair in CurrencyRatesData.currencyRates[0].Currency)
                {
                    file.Write("\n" + pair.Key + ";");
                    for (int i = indexToDate; i <= indexFromDate; i++)
                    {
                        file.Write(CurrencyRatesData.currencyRates[i].Currency[pair.Key] + ";");
                    }
                }
            }
            else
            {
                file.Write("\n" + currency + ";");
                for (int i = indexToDate; i <= indexFromDate; i++)
                {
                    file.Write(CurrencyRatesData.currencyRates[i].Currency[currency] + ";");
                }
            }
            file.Close();
            file.Dispose();
        }

        /// <summary>
        /// Конвертирует сумму из валюты А в валюту Б.
        /// </summary>
        /// <param name="sum">Сумма для конвертации</param>
        /// <param name="indexDate">Индекс даты в списке "List<CurrencyRates> currencyRates"</param>
        /// <param name="currencyA">Валюта А</param>
        /// <param name="currencyB">Валюта Б</param>
        /// <returns></returns>
        public static double ConvertCurrency(double sum, int indexDate, string currencyA, string currencyB)
        {
            return sum / CurrencyRatesData.currencyRates[indexDate].Currency[currencyA] * CurrencyRatesData.currencyRates[indexDate].Currency[currencyB];
        }
    }
}

