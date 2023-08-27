

using Microsoft.AspNetCore.Authorization;
using Services.Interfaces;

namespace API.ExtAuthorization;

public class ExtAuthorizeHandler : AuthorizationHandler<ExtAuthorizeRequirement>
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IConfiguration _configuration;
    private readonly ITokenBlacklistService _tokenBlacklistService;

    public ExtAuthorizeHandler(IHttpContextAccessor httpContextAccessor, IConfiguration configuration, ITokenBlacklistService tokenBlacklistService)
    {
        _httpContextAccessor = httpContextAccessor;
        _configuration = configuration;
        _tokenBlacklistService = tokenBlacklistService;
    }

    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ExtAuthorizeRequirement requirement)
    {
        HttpContext? httpContext = _httpContextAccessor.HttpContext;

        if (httpContext == null)
        {
            context.Fail();
            return Task.CompletedTask;
        }

        new AuthHelper(_tokenBlacklistService).AuthorizeRequest(httpContext, _configuration);


      
        return Task.CompletedTask;
    }

   
}