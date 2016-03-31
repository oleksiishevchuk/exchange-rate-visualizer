using System.Net;

namespace DataProvider
{
    internal class HttpManager
    {
        internal HttpManager(string userAgent, string acceptType)
        {
            UserAgent = userAgent;
            AcceptType = acceptType;
        }

        internal string AcceptType { get; private set; }

        internal string UserAgent { get; private set; }

        internal HttpWebResponse SendRequest(string uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = UserAgent;
            request.Accept = AcceptType;
            return (HttpWebResponse)request.GetResponse();
        }
    }
}
