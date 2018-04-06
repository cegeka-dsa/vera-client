using System.Diagnostics;
using VeraClient.Soap;

namespace VeraClient.Helpers
{
    public class ApiInvoker
    {
        private readonly SoapMessageBuilder _soapMessageBuilder;
        private readonly SoapMessageParser _soapMessageParser;

        public ApiInvoker(SoapMessageBuilder soapMessageBuilder, SoapMessageParser soapMessageParser)
        {
            _soapMessageBuilder = soapMessageBuilder;
            _soapMessageParser = soapMessageParser;
        }

        public TResp InvokeApiCall<TReq, TResp>(SoapClient soapClient, TReq request)
        {
            var sw = new Stopwatch();
            var operationName = typeof(TReq).Name;

            sw.Start();
            var body = Serialization.SerializeToXml(request);
            Logger.LoggerSingleton.Instance.LogInfo($"Serialization {operationName} to xml took {sw.Elapsed} milliseconds.");
            
            var response = InvokeApiCall(soapClient, operationName, body);

            sw.Restart();
            var result = Serialization.DeserializeFromXml<TResp>(response);
            Logger.LoggerSingleton.Instance.LogInfo($"Deserialization {operationName} from response took {sw.Elapsed} milliseconds.");

            return result;
        }

        public string InvokeApiCall(SoapClient soapClient, string operationName, string request)
        {
            var sw = new Stopwatch();

            var soapMessage = _soapMessageBuilder.SetBodyXml(request).CreateSoapMessage();
            Logger.LoggerSingleton.Instance.LogDebug(soapMessage);

            sw.Restart();
            var soapResponse = soapClient.GetSoapResponse(new SoapRequest(operationName, soapMessage));
            Logger.LoggerSingleton.Instance.LogInfo($"Soap call {operationName} to VERA endpoint took {sw.Elapsed} milliseconds.");

            var parser = _soapMessageParser.Parse(soapResponse.Response);

            return parser.InnerBody;
        }
    }
}