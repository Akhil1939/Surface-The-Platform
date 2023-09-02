namespace Surface.API.Responses
{
    public class ApiResponse<T>where T : class
    {
        public bool Success { get; }
        public int HttpStatusCode { get; }
        public string Message { get; }
        public T? Data { get; }
        public Dictionary<string, object>? Metadata { get; }

        public ApiResponse(bool success, int httpStatusCode, List<string> messages, T? data, Dictionary<string, object>? metadata)
        {
            Success = success;
            HttpStatusCode = httpStatusCode;
            Message = messages.First();
            Data = data;
            Metadata = metadata;
        }

    }
}
    

