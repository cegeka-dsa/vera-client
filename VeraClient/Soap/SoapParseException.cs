using System;
using System.Runtime.Serialization;

namespace VeraClient.Soap
{
    [Serializable]
    public class SoapParseException : Exception
    {
        public SoapParseException()
        {
        }

        public SoapParseException(string message) : base(message)
        {
        }

        public SoapParseException(string message, Exception inner) : base(message, inner)
        {
        }

        protected SoapParseException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
