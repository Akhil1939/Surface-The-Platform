using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface.Common.Constants
{
    public static class ExceptionMessage
    {
        public const string DEFAULT_MODELSTATE = "Model state is invalid!!!";
        public const string UNAUTHENTICATED = "Email id or password is incorrect!";

        public const string TOKEN_EXPIRED = "Session is Expired, try again!";
        public const string UNAUTHORIZED = "Unauthorized to access this resource";

        public const string FILE_IS_NULL = "File is null or empty!";
        public const string DATA_ALREADY_PRESENT = "Entity already available";
        public const string RESET_PASSWORD_TOKEN_EXPIRED = "Change password link is expired";
        public const string INVALID_CLAIMS = "Invalid claims";



    }
}
