using Microsoft.AspNetCore.Authorization;
using Surface.Common.Constants;

namespace StudentJobs.API.ExtAuthorization.PolicyAttributes
{
    public class EmployerPolicyAttribute : AuthorizeAttribute
    {
        public EmployerPolicyAttribute()
        {
            Policy = SystemConstant.EMPLOYER_POLICY;
        }
    }
}