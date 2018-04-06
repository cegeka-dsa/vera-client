using System.IO;
using System.Net;
using System.Text;

namespace VeraClient.Soap
{
    public class SoapClient
    {
        private string _url;

        private NetworkCredential _credentials;

        public SoapClient(string url, string username, string password)
        {
            var parts = username.Split('\\');
            var domain = string.Empty;
            if (parts.Length > 1)
            {
                username = parts[1];
                domain = parts[0];
            }

            Initialize(url, domain, username, password);
        }

        public SoapClient(string url, string domain, string username, string password)
        {
            Initialize(url, domain, username, password);
        }

        private void Initialize(string url, string domain, string username, string password)
        {
            _url = url;
            _credentials = new NetworkCredential(username, password, domain);

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public SoapResponse GetSoapResponse(SoapRequest request)
        {
            var webRequest = CreateWebRequest(request.Action);

            WriteMessageToWebRequest(webRequest, request.Message);

            return GetResponse(webRequest);
        }

        private HttpWebRequest CreateWebRequest(string action)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(_url);

            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            webRequest.Credentials = _credentials;
            webRequest.CookieContainer = new CookieContainer();
            webRequest.Headers.Add("soapAction", action);

            return webRequest;
        }

        private static void WriteMessageToWebRequest(HttpWebRequest webRequest, string message)
        {
            var content = Encoding.UTF8.GetBytes(message);
            using (var stream = webRequest.GetRequestStream())
            {
                stream.Write(content, 0, content.Length);
            }
        }

        private SoapResponse GetResponse(HttpWebRequest webRequest)
        {
            try
            {
                using (var response = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        var content = GetStringFromStream(responseStream, Encoding.GetEncoding(response.CharacterSet));

                        return new SoapResponse(response.StatusCode, content);
                    }
                }
            }
            catch (WebException exception)
            {
                var faultMessage = GetStringFromStream(exception.Response.GetResponseStream(), Encoding.GetEncoding(((HttpWebResponse)exception.Response).CharacterSet));

                throw new WebException(faultMessage, exception);
            }
        }

        private static string GetStringFromStream(Stream stream, Encoding encoding)
        {
            using (var sr = new StreamReader(stream, encoding))
            {
                return sr.ReadToEnd();
            }
        }
    }
}