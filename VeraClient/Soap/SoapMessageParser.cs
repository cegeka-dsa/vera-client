using System.Xml;

namespace VeraClient.Soap
{
    public class SoapMessageParser
    {
        public string InnerBody { get; set; }

        public SoapMessageParser Parse(string message)
        {
            var doc = new XmlDocument();
            doc.LoadXml(message);
            var mgr = new XmlNamespaceManager(doc.NameTable);
            mgr.AddNamespace("soap", NamespaceConstants.SoapEnvelopeNamespace);

            var bodyNode = doc.SelectSingleNode("/soap:Envelope/soap:Body", mgr);

            InnerBody = bodyNode?.InnerXml ?? throw new SoapParseException("Invalid soap message: body not found.");

            return this;
        }
    }
}