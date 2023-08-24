using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Surface_API.Areas.Admin.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // GET: api/<AccountController>
        [HttpPost("register")]

        public IActionResult Register()
        {
            return Ok("register done!");
        }

        [HttpPost]
        [Route("api/verifytoken")]
        public IActionResult VerifyToken([FromBody] string idToken)
        {
            try
            {
                var payload = GoogleJsonWebSignature.ValidateAsync(idToken, new GoogleJsonWebSignature.ValidationSettings()).Result;

                // At this point, the token is successfully verified.
                // You can access the user's information from the 'payload' variable.

                // For example, you can access the user's email like this:
                string userEmail = payload.Email;

                // Your custom logic after successful token verification...

                return Ok(payload);
            }
            catch (Exception ex)
            {
                // If the token verification fails, handle the exception here.
                return BadRequest("Invalid token: " + ex.Message);
            }
        }
    }

}
