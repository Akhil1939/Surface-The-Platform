using System.Net;

namespace Surface.Common.CustomExceptions
{
    public class DataAlreadyExistsException : Exception
    {
        public int StatusCode { get; set; } = (int)HttpStatusCode.Conflict;
        public List<string> Messages { get; set; }
        public Dictionary<string, object>? Metadata { get; set; }

        public DataAlreadyExistsException(string message, Dictionary<string, object>? metadata = null) : base(message)
        {
            StatusCode = (int)HttpStatusCode.Conflict;
            Messages = new List<string> { message };
            Metadata = metadata;
        }
        public DataAlreadyExistsException(List<string> message, Dictionary<string, object>? metadata = null) : base(message[0])
        {
            StatusCode = (int)HttpStatusCode.Conflict;
            Messages = message;
            Metadata = metadata;
        }
    }
}
