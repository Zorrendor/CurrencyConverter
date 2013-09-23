using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;
using System.IO;


namespace СurrencyConverter
{
    public partial class MainForm : Form
    {
        public static List<CurrencyRates> currencyRates = new List<CurrencyRates>();

        public MainForm()
        {
            InitializeComponent();
        }


        // Парсинг xml документа, сохранение данных в List<CurrencyRates> currencyRates,
        // инициализация элементов формы.
        private void MainForm_Load(object sender, EventArgs e)
        {

            XElement rootForCurrency =  new XElement(readXmlFile());
            
            int i = 0;
            
            foreach (XElement el in rootForCurrency.Elements())
            {
                currencyRates.Add(new CurrencyRates());
                currencyRates[i].Date = DateTime.Parse(el.Attribute("time").Value);
                fromDate.Items.Add(currencyRates[i].Date);
                toDate.Items.Add(currencyRates[i].Date);
                convertDate.Items.Add(currencyRates[i].Date);
                foreach (XElement cur in el.Elements())
                {
                    //currencyRates[i].Currency.Add(cur.Attribute("currency").Value, double.Parse(cur.Attribute("rate").Value, CultureInfo.GetCultureInfo("en-US")));
                    currencyRates[i].AddCurrency(cur.Attribute("currency").Value, double.Parse(cur.Attribute("rate").Value, CultureInfo.GetCultureInfo("en-US")));
                }
                i++;
            }

            fromDate.SelectedIndex = currencyRates.Count - 1;
            toDate.SelectedIndex = 0;
            convertDate.SelectedIndex = 0;
            currency.Items.Add("All");
            currency.SelectedIndex = 0;
            foreach (KeyValuePair<string, double> pair in currencyRates[0].Currency)
            {
                currency.Items.Add(pair.Key);
                currencyA.Items.Add(pair.Key);
                currencyB.Items.Add(pair.Key);
            }
            currencyA.SelectedIndex = 0;
            currencyB.SelectedIndex = 0;
        }

        private XElement readXmlFile()
        {
            string fileName = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
            XDocument xml = XDocument.Load(fileName);
            return xml.Root.Elements().Last();
        }

        private void showRates_Click(object sender, EventArgs e)
        {
            RatesForm form = new RatesForm(fromDate.SelectedIndex, toDate.SelectedIndex, currency.Text);
            form.ShowDialog(this);
        }

        private void convertTo_Click(object sender, EventArgs e)
        {
            double result = 0;
            double temp = 0;
            // Можно объявить в начале, в зависимости или от выбранных настроек, или по-умолчанию 
            // применить к датам, числам и т.д.
            CultureInfo culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            switch (inputFormat.SelectedIndex)
            {
                case 0: culture = new CultureInfo("en-US");
                    break;
                case 1: culture = new CultureInfo("ru-RU");
                    break;
            }
            try
            {
                if (String.IsNullOrWhiteSpace(countA.Text))
                {
                    throw new InputDoubleException("Empty sum input.");
                }
                //if (countA.Text.Any(c => char.IsLetter(c)))
                //{
                //    throw new InputDoubleException("Input sum has letters");
                //}
                foreach (char c in countA.Text)
                {
                    if (char.IsNumber(c))
                    {
                        continue;
                    }
                    if (char.IsLetter(c))
                    {
                        throw new InputDoubleException("Input sum has letters.");
                    }
                    if (char.IsPunctuation(c) && c != ',' && c != '.')
                    {
                        throw new InputDoubleException("Input sum has punctuations.");
                    }
                }
                

                // Допускаем пробелы в начале и конце
                temp = double.Parse(countA.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint, culture);
            }

            catch (InputDoubleException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            result = temp / currencyRates[convertDate.SelectedIndex].Currency[currencyA.Text] * currencyRates[convertDate.SelectedIndex].Currency[currencyB.Text];
            countB.Text = result.ToString(culture);
       }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".csv|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.WriteInFile(saveFileDialog.FileName);
                saveFileDialog.Dispose();
            }
        }


        // Запись в файл, есть вероятность одновременной записи в 1 файл

        private void WriteInFile(string fileName)
        {
            StreamWriter file = null;
            try
            {
                file = new StreamWriter(fileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            file.Write("Currency\\Date;");
            for (int i = toDate.SelectedIndex; i <= fromDate.SelectedIndex; i++)
            {
                //file.Write(cube[i].Date.ToString("dd.MM.yyyy") + ";");
                file.Write(currencyRates[i].Date.ToString("yyyy.MM.dd") + ";");
            }
            if (currency.Text == "All")
            {
                foreach (KeyValuePair<string, double> pair in currencyRates[0].Currency)
                {
                    file.Write("\n" + pair.Key + ";");
                    for (int i = toDate.SelectedIndex; i <= fromDate.SelectedIndex; i++)
                    {
                        file.Write(currencyRates[i].Currency[pair.Key] + ";");
                    }
                }
            }
            else
            {
                file.Write("\n" + currency.Text + ";");
                for (int i = toDate.SelectedIndex; i <= fromDate.SelectedIndex; i++)
                {
                    file.Write(currencyRates[i].Currency[currency.Text] + ";");
                }
            }
            file.Close();
            file.Dispose();
        }
    }
}
