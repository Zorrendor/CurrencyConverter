using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace СurrencyConverter
{
    public partial class RatesForm : Form
    {
        private int indexFromDate;
        private int indexToDate;
        private string keyCurrency;

        public RatesForm(int indexFromDate, int indexToDate, string keyCurrency)
        {
            this.indexFromDate = indexFromDate;
            this.indexToDate = indexToDate;
            this.keyCurrency = keyCurrency;
            InitializeComponent();
        }

        private void Rates_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            dataRates.Columns.Add("Currency\\Date", "Currency\\Date");
            for (int i = indexToDate; i <= indexFromDate; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = MainForm.currencyRates[i].Date.ToString("dd.MM.yyyy");
                dataRates.Columns.Add(column);
            }
            
            if (keyCurrency == "All")
            {
                dataRates.Rows.Add(MainForm.currencyRates[0].Currency.Count);
                int x = 0, y = 0;
                foreach (KeyValuePair<string, double> pair in MainForm.currencyRates[0].Currency)
                {
                    y = 1;
                    dataRates.Rows[x].Cells[0].Value = pair.Key;
                    for (int i = indexToDate; i <= indexFromDate; i++)
                    {
                        dataRates.Rows[x].Cells[y].Value = MainForm.currencyRates[i].Currency[pair.Key];
                        //dataRates.Rows[x].Cells[y].Value = pair.Value;
                        y++;
                    }
                    x++;
                }
            }
            else
            {
                dataRates.Rows.Add();
                dataRates[0, 0].Value = keyCurrency;
                int y = 1;
                for (int i = indexToDate; i <= indexFromDate; i++)
                {
                    dataRates[y, 0].Value = MainForm.currencyRates[i].Currency[keyCurrency];
                    y++;
                }
            }
        }

    }
}
