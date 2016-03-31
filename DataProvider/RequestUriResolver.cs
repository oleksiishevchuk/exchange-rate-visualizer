using System;
using DataProvider.API;

namespace DataProvider
{
    internal static class RequestUriResolver
    {
        internal static string Resolve(Currency currency)
        {
            switch (currency)
            {
                case Currency.USD:
                    return "http://minfin.com.ua/data/currency/ib/usd.ib.today.json";
                case Currency.EUR:
                    return "http://minfin.com.ua/data/currency/ib/eur.ib.today.json";
                default:
                    throw new NotSupportedException(string.Format("Currency {0} is not supported", currency));
            }
        }
    }
}
