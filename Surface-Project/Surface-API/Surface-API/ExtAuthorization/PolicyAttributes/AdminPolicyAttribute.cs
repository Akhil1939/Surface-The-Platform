using Microsoft.AspNetCore.Authorization;
using Surface.Common.Constants;

namespace StudentJobs.API.ExtAuthorization.PolicyAttributes;

public class AdminPolicyAttribute : AuthorizeAttribute
{
    public AdminPolicyAttribute()
    {
        Policy = SystemConstant.ADMIN_POLICY;
    }
}