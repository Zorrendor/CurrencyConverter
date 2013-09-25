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


        public MainForm()
        {
            InitializeComponent();
        }


        // Парсинг xml документа, сохранение данных в List<CurrencyRates> currencyRates,
        // инициализация элементов формы.
        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrencyRates.LoadXmlFile();
            foreach (CurrencyRates cr in CurrencyRatesData.currencyRates)
            {
                fromDate.Items.Add(cr.Date);
                toDate.Items.Add(cr.Date);
                convertDate.Items.Add(cr.Date);
            }

            fromDate.SelectedIndex = CurrencyRatesData.currencyRates.Count - 1;
            toDate.SelectedIndex = 0;
            convertDate.SelectedIndex = 0;
            currency.Items.Add("All");
            currency.SelectedIndex = 0;
            foreach (KeyValuePair<string, double> pair in CurrencyRatesData.currencyRates[0].Currency)
            {
                currency.Items.Add(pair.Key);
                currencyA.Items.Add(pair.Key);
                currencyB.Items.Add(pair.Key);
            }
            currencyA.SelectedIndex = 0;
            currencyB.SelectedIndex = 0;
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
            //CultureInfo culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            switch (inputFormat.SelectedIndex)
            {
                case 0: CurrencyRatesData.Culture = new CultureInfo("en-US");
                    break;
                case 1: CurrencyRatesData.Culture = new CultureInfo("ru-RU");
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
                temp = double.Parse(countA.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint, CurrencyRatesData.Culture);
            }

            catch (InputDoubleException myEx)
            {
                MessageBox.Show(myEx.Message);
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            result = CurrencyRates.ConvertCurrency(temp, convertDate.SelectedIndex, currencyA.Text, currencyB.Text);
            countB.Text = result.ToString(CurrencyRatesData.Culture);
       }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".csv|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CurrencyRates.WriteInFile(saveFileDialog.FileName, toDate.SelectedIndex, fromDate.SelectedIndex, currency.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                saveFileDialog.Dispose();
            }
        }
    }
}
