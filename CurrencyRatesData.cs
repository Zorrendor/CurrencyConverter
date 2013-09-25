using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace СurrencyConverter
{
    /// <summary>
    /// Класс хранит данные 
    /// </summary>
    public static class CurrencyRatesData
    {
        /// <summary>
        /// Список курсов валют
        /// </summary>
        public static List<CurrencyRates> currencyRates = new List<CurrencyRates>();
        /// <summary>
        /// Информация о выбранной локализации
        /// </summary>
        public static CultureInfo Culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
    }
}
