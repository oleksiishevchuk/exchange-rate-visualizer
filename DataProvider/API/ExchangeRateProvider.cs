using System.Collections.Generic;

namespace DataProvider.API
{
    public class ExchangeRateProvider
    {
        private const string AcceptType = "application/json";
        private const string UserAgent = "Chrome";

        public List<CurrencyRate> GetExchangeRates(Currency currency)
        {
            var httpManager = new HttpManager(UserAgent, AcceptType);
            var response = httpManager.SendRequest(RequestUriResolver.Resolve(currency));
            return HttpResponseHandler.GetCurrencyRates(response);
        }
    }
}
