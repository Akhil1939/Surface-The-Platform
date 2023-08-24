using Microsoft.AspNetCore.Authorization;
using Surface.Common.Constants;

namespace StudentJobs.API.ExtAuthorization.PolicyAttributes
{
    public class EmployeePolicyAttribute : AuthorizeAttribute
    {
        public EmployeePolicyAttribute()
        {
            Policy = SystemConstant.EMPLOYEE_POLICY;
        }
    }
}