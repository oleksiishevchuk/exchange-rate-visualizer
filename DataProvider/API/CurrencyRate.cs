using System;

namespace DataProvider.API
{
    public class CurrencyRate
    {
        public decimal Bid { get; set; }

        public decimal Ask { get; set; }

        public DateTime Date { get; set; }
    }
}
