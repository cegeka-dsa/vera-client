namespace VeraClient.Soap
{
    public class SoapRequest
    {
        public string Action { get; set; }

        public string Message { get; set; }

        public SoapRequest(string action, string message)
        {
            Action = action;
            Message = message;
        }
    }
}
