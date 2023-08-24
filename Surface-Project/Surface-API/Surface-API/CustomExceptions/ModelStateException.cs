using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace Surface.API.CustomExceptions
{
    public class ModelStateException : Exception
    {
        public int StatusCode { get; set; }
        public List<string> Messages { get; set; }

        public ModelStateException(ModelStateDictionary modelState)
            : base(GetFirstErrorMessage(modelState))
        {
            StatusCode = (int)HttpStatusCode.BadRequest;
            Messages = GetErrorMessage(modelState);
        }

        private static string GetFirstErrorMessage(ModelStateDictionary modelState)
        {
            if (modelState != null && modelState.Count > 0)
            {
                var firstError = modelState.Values.First().Errors.FirstOrDefault();
                if (firstError != null)
                    return firstError.ErrorMessage;
            }
            return "Model state is invalid!";
        }

        private static List<string> GetErrorMessage(ModelStateDictionary modelState)
        {
            var listOfMessages = new List<string>();
            if (modelState != null && modelState.Count > 0)
            {
                foreach (var keyValuePair in modelState)
                {
                    foreach (var error in keyValuePair.Value.Errors)
                    {
                        listOfMessages.Add(error.ErrorMessage);
                    }
                }
            }
            return listOfMessages;
        }
    }
}
