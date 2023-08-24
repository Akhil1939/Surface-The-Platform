using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Surface.API.Responses;
using Surface.Common.Constants;
using Surface.Common.CustomExceptions;
using System.Net;
using System.Security.Authentication;

namespace Surface.API.Middlewares
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        public async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            ApiResponse<object> response = GenerateErrorResponse(context, ex);
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            string jsonResponse = JsonConvert.SerializeObject(response, serializerSettings);
            await context.Response.WriteAsync(jsonResponse);
        }

        public ApiResponse<Object> GenerateErrorResponse(HttpContext context, Exception ex)
        {
            (int httpStatusCode, List<string> messages, Dictionary<string, object>? metadata) = GetExceptionInfo(ex);

            context.Response.StatusCode = httpStatusCode;

            return new ApiResponse<object>(false, httpStatusCode, messages, null, metadata);

        }

        public (int, List<string>, Dictionary<string, object>?) GetExceptionInfo(Exception ex)
        {
            List<string> messages = new();
            int httpStatusCode = (int)HttpStatusCode.InternalServerError;

            void AddStatusCodeAndMessage(int statusCode, string message)
            {
                httpStatusCode = statusCode;
                messages.Add(message);
            }
            //all exception switch cases goes here
            switch (ex)
            {
                case UnauthorizedAccessException unauthorizedAccessException:
                    AddStatusCodeAndMessage((int)HttpStatusCode.Unauthorized, unauthorizedAccessException.Message);
                    break;

                case AuthenticationException authenticationException:
                    AddStatusCodeAndMessage((int)HttpStatusCode.Unauthorized, authenticationException.Message);
                    break;
                case DbUpdateException dbUpdateException:

                    //For duplicate value 
                    if (dbUpdateException.InnerException is SqlException sqlException && sqlException.Number == 2601)
                    {
                        AddStatusCodeAndMessage(httpStatusCode, ExceptionMessage.DATA_ALREADY_PRESENT);
                    }
                    break;

                case InvalidOperationException:
                    AddStatusCodeAndMessage(400, "Data not found!");
                    break;
                case EntityNullException entityNullException: 
                    AddStatusCodeAndMessage(entityNullException.StatusCode, entityNullException.Message);
                    break;
                default:
                    messages.Add(ex.Message);
                    break;
            }
            return (httpStatusCode, messages, null);
        }

    }
}
