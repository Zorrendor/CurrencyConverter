using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Globalization;
using System.IO;


namespace СurrencyConverter
{
    /// <summary>
    /// Класс содержит список курса валют для разных дат и методы для работы с ними.
    /// </summary>

    public class CurrencyRatesData
    {
        private static List<CurrencyRates> currencyRates = new List<CurrencyRates>();
        /// <summary>
        /// Список курсов валют
        /// </summary>
        public static List<CurrencyRates> CurrencyRates 
        { 
            get { return currencyRates; }
            set { currencyRates = value; }
        }
        private static CultureInfo culture = new CultureInfo(CultureInfo.CurrentCulture.Name); 
        /// <summary>
        /// Информация о выбранной локализации
        /// </summary>
        public static CultureInfo Culture
        {
            get { return culture; }
            set { culture = value; }
        }

        /// <summary>
        /// Загрузка из xml файла.
        /// </summary>
        public void LoadXmlFile()
        {
            string fileName = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";

            XDocument xml = XDocument.Load(fileName);
            XElement rootForCurrency = new XElement(xml.Root.Elements().Last());
            int i = 0;

            foreach (XElement el in rootForCurrency.Elements())
            {
                CurrencyRatesData.CurrencyRates.Add(new CurrencyRates());
                CurrencyRatesData.CurrencyRates[i].Date = DateTime.Parse(el.Attribute("time").Value);
                foreach (XElement cur in el.Elements())
                {
                    //currencyRates[i].Currency.Add(cur.Attribute("currency").Value, double.Parse(cur.Attribute("rate").Value, CultureInfo.GetCultureInfo("en-US")));
                    CurrencyRatesData.CurrencyRates[i].AddCurrency(cur.Attribute("currency").Value, double.Parse(cur.Attribute("rate").Value, CultureInfo.GetCultureInfo("en-US")));
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
        public void WriteInFile(string fileName, int indexToDate, int indexFromDate, string currency)
        {
            StreamWriter file = new StreamWriter(fileName);
            file.Write("Currency\\Date;");
            for (int i = indexToDate; i <= indexFromDate; i++)
            {
                //file.Write(cube[i].Date.ToString("dd.MM.yyyy") + ";");
                file.Write(CurrencyRatesData.CurrencyRates[i].Date.ToString("yyyy.MM.dd") + ";");
            }
            if (currency == "All")
            {
                foreach (KeyValuePair<string, double> pair in CurrencyRatesData.CurrencyRates[0].Currency)
                {
                    file.Write("\n" + pair.Key + ";");
                    for (int i = indexToDate; i <= indexFromDate; i++)
                    {
                        file.Write(CurrencyRatesData.CurrencyRates[i].Currency[pair.Key] + ";");
                    }
                }
            }
            else
            {
                file.Write("\n" + currency + ";");
                for (int i = indexToDate; i <= indexFromDate; i++)
                {
                    file.Write(CurrencyRates[i].Currency[currency] + ";");
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
        public double ConvertCurrency(double sum, int indexDate, string currencyA, string currencyB)
        {
            return sum / CurrencyRates[indexDate].Currency[currencyA] * CurrencyRates[indexDate].Currency[currencyB];
        }
    }
}
