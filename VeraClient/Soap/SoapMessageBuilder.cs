using System.Xml;

namespace VeraClient.Soap
{
    public class SoapMessageBuilder
    {
        private const string SoapEnvelopePrefix = "soapenv";
        private const string SoapEnvelopeElementName = "Envelope";
        private const string SoapHeaderElementName = "Header";
        private const string SoapBodyElementName = "Body";
        private string _headerXml;
        private string _bodyXml;

        public SoapMessageBuilder SetHeaderXml(string headerXml)
        {
            _headerXml = headerXml;
            return this;
        }

        public SoapMessageBuilder SetBodyXml(string bodyXml)
        {
            _bodyXml = bodyXml;
            return this;
        }

        public string CreateSoapMessage()
        {
            var doc = new XmlDocument();

            var soapEnvelope = doc.CreateElement(SoapEnvelopePrefix, SoapEnvelopeElementName, NamespaceConstants.SoapEnvelopeNamespace);

            if (!string.IsNullOrWhiteSpace(_headerXml))
            {
                var soapHeader = doc.CreateElement(SoapEnvelopePrefix, SoapHeaderElementName, NamespaceConstants.SoapEnvelopeNamespace);
                soapEnvelope.AppendChild(soapHeader);
                doc.LoadXml(_headerXml);
                soapHeader.AppendChild(doc.DocumentElement);
            }

            var soapBody = doc.CreateElement(SoapEnvelopePrefix, SoapBodyElementName, NamespaceConstants.SoapEnvelopeNamespace);
            soapEnvelope.AppendChild(soapBody);
            doc.LoadXml(_bodyXml);
            soapBody.AppendChild(doc.DocumentElement);

            return soapEnvelope.OuterXml;
        }
    }
}
