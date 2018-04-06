using vera;
using VeraClient.Helpers;
using VeraClient.Soap;

namespace VeraClient.Agents
{
    public class KeuzeboomAgent
    {
        private readonly SoapClient _soapClient;
        private readonly ApiInvoker _veraHelper;

        public KeuzeboomAgent(SoapClient soapClient, ApiInvoker veraHelper)
        {
            _soapClient = soapClient;
            _veraHelper = veraHelper;
        }

        public dgormsDu02 GetRuimteSoorten(string eenheidCode)
        {
            var requestMessage = new dgormsDi02
            {
                @object = new DGORMSvraag
                {
                    eenheid = new VASEENkerngegevens {identificatie = new Sleutele {Value = eenheidCode}}
                }
            };

            return _veraHelper.InvokeApiCall<dgormsDi02, dgormsDu02>(_soapClient, requestMessage);
        }

        public dgobweDu02 GetBouwElementen(string eenheidCode, string ruimteSoortCode)
        {
            var requestMessage = new dgobweDi02
            {
                @object = new DGOBWEvraag
                {
                    ruimteSoort = new DGORMSbasis {code = new Referentiedatacodee {Value = ruimteSoortCode}},
                    eenheid = new VASEENkerngegevens {identificatie = new Sleutele {Value = eenheidCode}}
                }
            };

            return _veraHelper.InvokeApiCall<dgobweDi02, dgobweDu02>(_soapClient, requestMessage);
        }

        public dgoodlDu02 GetOnderdelen(string eenheidCode, string ruimteSoortCode, string bouwElementCode)
        {
            var requestMessage = new dgoodlDi02
            {
                @object = new DGOODLvraag
                {
                    ruimteSoort = new DGORMSbasis {code = new Referentiedatacodee {Value = ruimteSoortCode}},
                    bouwElement = new DGOBWEbasis {code = new Referentiedatacodee {Value = bouwElementCode}},
                    eenheid = new VASEENkerngegevens {identificatie = new Sleutele {Value = eenheidCode}}
                }
            };

            return _veraHelper.InvokeApiCall<dgoodlDi02, dgoodlDu02>(_soapClient, requestMessage);
        }

        public dgogbrDu02 GetGebreken(string eenheidCode, string ruimteSoortCode, string bouwElementCode, string onderdeelCode)
        {
            var requestMessage = new dgogbrDi02
            {
                @object = new DGOGBRvraag
                {
                    ruimteSoort = new DGORMSbasis {code = new Referentiedatacodee {Value = ruimteSoortCode}},
                    bouwElement = new DGOBWEbasis {code = new Referentiedatacodee {Value = bouwElementCode}},
                    onderdeel = new DGOODLbasis {code = new Referentiedatacodee {Value = onderdeelCode}},
                    eenheid = new VASEENkerngegevens {identificatie = new Sleutele {Value = eenheidCode}}
                }
            };

            return _veraHelper.InvokeApiCall<dgogbrDi02, dgogbrDu02>(_soapClient, requestMessage);
        }

        public dgoorzDu02 GetOorzaken()
        {
            var requestMessage = new dgoorzDi02
            {
                @object = new DGOORZvraag()
            };

            return _veraHelper.InvokeApiCall<dgoorzDi02, dgoorzDu02>(_soapClient, requestMessage);
        }

        public dgospcDu02 GetSpecificatie(string eenheidCode, string ruimteSoortCode, string bouwElementCode, string onderdeelCode, string gebrekCode)
        {
            var requestMessage = new dgospcDi02
            {
                @object = new DGOSPCvraag
                {
                    ruimteSoort = new DGORMSbasis {code = new Referentiedatacodee {Value = ruimteSoortCode}},
                    bouwElement = new DGOBWEbasis {code = new Referentiedatacodee {Value = bouwElementCode}},
                    onderdeel = new DGOODLbasis {code = new Referentiedatacodee {Value = onderdeelCode}},
                    gebrek = new DGOGBRbasis {code = new Referentiedatacodee {Value = gebrekCode}},
                    eenheid = new VASEENkerngegevens {identificatie = new Sleutele {Value = eenheidCode}}
                }
            };

            return _veraHelper.InvokeApiCall<dgospcDi02, dgospcDu02>(_soapClient, requestMessage);
        }

        public dgokhuDu02 WordtKlantDoorbelast(string huurderCode, string eenheidCode, string keuzeBoomStapCode, string oorzaakCode = null)
        {
            var requestMessage = new dgokhuDi02
            {
                @object = new DGOKHUvraag
                {
                    huurder = new RELRELkerngegevens {identificatie = new Sleutele {Value = huurderCode}},
                    eenheid = new VASEENkerngegevens {identificatie = new Sleutele {Value = eenheidCode}},
                    keuzeboomstap = new DGOKBSkerngegevens {identificatie = new Sleutele {Value = keuzeBoomStapCode}}
                }
            };

            if (!string.IsNullOrEmpty(oorzaakCode))
                requestMessage.@object.oorzaak = new ALGREFbasis {identificatie = new Sleutele {Value = oorzaakCode}};

            return _veraHelper.InvokeApiCall<dgokhuDi02, dgokhuDu02>(_soapClient, requestMessage);
        }
    }
}