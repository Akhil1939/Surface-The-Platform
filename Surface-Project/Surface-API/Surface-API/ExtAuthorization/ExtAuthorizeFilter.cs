using API.ExtAuthorization;
using Microsoft.AspNetCore.Mvc.Filters;

using Services.Interfaces;

namespace Surface.API.ExtAuthorization
{
    public class ExtAuthorizeFilter : IAuthorizationFilter
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        private readonly ITokenBlacklistService _tokenBlacklistService;


        public ExtAuthorizeFilter(IHttpContextAccessor httpContextAccessor, IConfiguration configuration, ITokenBlacklistService tokenBlacklistService)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _tokenBlacklistService = tokenBlacklistService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (_httpContextAccessor == null || _httpContextAccessor.HttpContext == null)
                throw new UnauthorizedAccessException();

            new AuthHelper(_tokenBlacklistService).AuthorizeRequest(_httpContextAccessor.HttpContext, _configuration);
        }
    }
}
