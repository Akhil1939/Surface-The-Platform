﻿namespace Surface.API.Responses
{
    public class ApiResponse<T>where T : class
    {
        public bool Success { get; }
        public int HttpStatusCode { get; }
        public List<string> Messages { get; }
        public T? Data { get; }
        public Dictionary<string, object>? Metadata { get; }

        public ApiResponse(bool success, int httpStatusCode, List<string> messages, T? data, Dictionary<string, object>? metadata)
        {
            Success = success;
            HttpStatusCode = httpStatusCode;
            Messages = messages;
            Data = data;
            Metadata = metadata;
        }

    }
}
    

