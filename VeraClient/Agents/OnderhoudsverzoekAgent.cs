using vera;
using VeraClient.Helpers;
using VeraClient.Soap;

namespace VeraClient.Agents
{
    public class OnderhoudsverzoekAgent
    {
        private readonly SoapClient _soapClient;
        private readonly ApiInvoker _veraHelper;

        public OnderhoudsverzoekAgent(SoapClient soapClient, ApiInvoker veraHelper)
        {
            _soapClient = soapClient;
            _veraHelper = veraHelper;
        }

        public dgokhuDu02 WordtKlantDoorbelast(string huurderCode, string eenheidCode, string keuzeboomStapCode, string oorzaakCode)
        {
            var request = $"<ns:dgokhuDi02 xmlns:ns='http://www.stichting-vera.nl/StUF/verticaal/dagelijksonderhoud/0301' xmlns:stuf='http://www.egem.nl/StUF/StUF0301' xmlns:ns1='http://www.stichting-vera.nl/StUF/sector/vera/0310'><ns:object><ns:huurder><ns1:identificatie>{huurderCode}</ns1:identificatie></ns:huurder><ns:eenheid><ns1:identificatie>{eenheidCode}</ns1:identificatie></ns:eenheid><ns:keuzeboomstap><ns:identificatie>{keuzeboomStapCode}</ns:identificatie></ns:keuzeboomstap><ns:oorzaak><ns1:code>{oorzaakCode}</ns1:code></ns:oorzaak></ns:object></ns:dgokhuDi02>";

            var response = _veraHelper.InvokeApiCall(_soapClient, "dgokhuDi02", request);
            return Serialization.DeserializeFromXml<dgokhuDu02>(response);
        }

        public Bv02Bericht CreateOnderhoudsVerzoek(string huurderCode, string meldercode, string eenheidCode, string keuzeboomStapCode, string oorzaakCode)
        {
            var request = $@"<ns:dgoondLk02 xmlns:ns='http://www.stichting-vera.nl/StUF/verticaal/dagelijksonderhoud/0301' xmlns:stuf='http://www.egem.nl/StUF/StUF0301' xmlns:ns1='http://www.stichting-vera.nl/StUF/sector/vera/0310'>
         <ns:stuurgegevens><stuf:berichtcode>Lk02</stuf:berichtcode><stuf:entiteittype>DGOOND</stuf:entiteittype></ns:stuurgegevens>
         <ns:parameters><stuf:mutatiesoort>T</stuf:mutatiesoort></ns:parameters>
         <ns:object><ns1:eenheid><ns1:identificatie>{eenheidCode}</ns1:identificatie></ns1:eenheid>
            <ns:melder><ns1:identificatie>{meldercode}</ns1:identificatie>
            </ns:melder>
            <ns:huurder><ns1:identificatie>{huurderCode}</ns1:identificatie></ns:huurder>
            <ns:keuzeboomStap><ns:identificatie>{keuzeboomStapCode}</ns:identificatie></ns:keuzeboomStap>
            <ns:oorzaak><ns1:code>{oorzaakCode}</ns1:code></ns:oorzaak>
            <ns:huurderAccepteertKosten>true</ns:huurderAccepteertKosten>
        </ns:object>
        </ns:dgoondLk02>";


            var response = _veraHelper.InvokeApiCall(_soapClient, "dgoondLk02", request);
            return Serialization.DeserializeFromXml<Bv02Bericht>(response);
        }
    }
}