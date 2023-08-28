using Microsoft.AspNetCore.Mvc;
using Surface.API.Responses;

namespace Surface.API.Utils
{
    public class SuccessResponseHelper<T> where T : class
    {
        public IActionResult GetSuccessResponse(int statusCode, List<string> messages, Dictionary<string, object>? Metadata, T? data = null)
        {
            ApiResponse<T> successResponse = new(true, statusCode, messages, data, Metadata);
            
            return new ObjectResult(successResponse)
            {
                StatusCode = statusCode,
            };
        }
        public IActionResult GetSuccessResponse(int statusCode, string message, T? data = null)
        {
            ApiResponse<T> successApiResponse = new(true, statusCode, new List<string>() { message},data,null);

            return new ObjectResult(successApiResponse)
            {
                StatusCode = statusCode,
            };

        }

        public IActionResult GetSuccessResponse(int statusCode, T? content = null)
        {
            ApiResponse<T> successApiResponse = new(true,statusCode, new List<string>(), content, null);

            return new ObjectResult(successApiResponse)
            {
                StatusCode = statusCode,
            };

        }
    }
}
