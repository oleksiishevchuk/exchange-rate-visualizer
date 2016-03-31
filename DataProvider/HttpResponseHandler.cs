using DataProvider.API;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DataProvider
{
    internal static class HttpResponseHandler
    {
        public static List<CurrencyRate> GetCurrencyRates(HttpWebResponse response)
        {
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader(response.GetResponseStream()))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                return (List<CurrencyRate>)serializer.Deserialize(jsonTextReader, typeof(List<CurrencyRate>));
            }
        }
    }
}
