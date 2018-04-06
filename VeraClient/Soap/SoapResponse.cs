using System.Net;

namespace VeraClient.Soap
{
    public class SoapResponse
    {
        public HttpStatusCode StatusCode { get; internal set; }
        public string Response { get; set; }
        
        public SoapResponse(HttpStatusCode statusCode, string response)
        {
            StatusCode = statusCode;
            Response = response;
        }
    }
}
