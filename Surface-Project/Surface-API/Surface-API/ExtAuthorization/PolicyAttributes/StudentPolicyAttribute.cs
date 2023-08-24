using Microsoft.AspNetCore.Authorization;
using Surface.Common.Constants;

namespace StudentJobs.API.ExtAuthorization.PolicyAttributes
{
    public class StudentPolicyAttribute : AuthorizeAttribute
    {
        public StudentPolicyAttribute()
        {
            Policy = SystemConstant.STUDENT_POLICY;
        }
    }
}