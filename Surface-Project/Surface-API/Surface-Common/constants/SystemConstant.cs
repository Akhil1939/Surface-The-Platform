namespace Surface.Common.Constants
{
    public static class SystemConstant
    {
        public const string CONNECTION_STRING_NAME = "DefaultConnection";
        public const string DEFAULT_SORTCOLUMN = "Id";
        public const string ASCENDING = "ascending";
        public const string DESCENDING = "descending";
        public const int DEFAULT_PAGE_SIZE = 10;
        public const int DEFAULT_PAGE_INDEX = 1;
        public const string CORS_ALLOW_ANY = "AllowAny";
        public const string DEFAULT_AVATAR = "'/assets/user/avatar/default-avatar.png'";
        public const string DEFAULT_DATETIME = "(getutcdate())";
        public const byte DEFAULT_USER_ROLE = 1;
        public const int KEY_SIZE = 64;

        public const string JWT_SETTING = "JwtSetting";
        public const string AUTH_TOKEN = "AuthToken";
        public const byte DEFAULT_LOGINPROVIDER_ID = 1;
        public const byte DEFAULT_LANGUAGE_ID = 1;
        public const byte DEFAULT_TIMEZONE_FORMATION_ID = 1;
        public const byte DEFAULT_ACCESS_FAILED_COUNT = 0;
        public const bool DEFAULT_MUST_CHANGE_PASSWORD = false;
        public const int ITERATION_COUNT = 350000;

        public const string CACHE_KEY = "AuthTokenBlacklist";
        public const string SESSION_USER = "SessionUser";

        public const string ADMIN_POLICY = "AdminPolicy";
        public const string STUDENT_POLICY = "StudentPolicy";
        public const string EMPLOYEE_POLICY = "EmployeePolicy";
        public const string EMPLOYER_POLICY = "EmployeerPolicy";
        public const string PREFIX_BEARER_TOKEN = "Bearer ";

        public const string WWWROOT_PATH = "/wwwroot";

        public const string EMPLOYER_AVTAR = "/employer/avtar";

        public const string ASSETS_PATH = "/assets";
        public const string AVATAR_PATH = "/user/avatar";
    }
}
