using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}

