using Microsoft.AspNetCore.Mvc;
using Surface.API.Utils;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Surface_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;
        public AccountController(IAccountService service)
        {
            _service = service;
            
        }
        // GET: api/<UserController>

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO dto)
        {
            
            await _service.AddAsync(dto);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200,"User added successfully", null);
        }

        // PUT api/<UserController>/5
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto)
        {
           LoginResponseDTO response =  await _service.Login(dto);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200, "User Login successfully", response);
        }
        [HttpPost("ContinueWithGoogle")]
        public async Task<IActionResult> ContinueWithGoogle([FromBody] SocialLoginDTO dto)
        {
            return new SuccessResponseHelper<LoginResponseDTO>().GetSuccessResponse(200, "Success", await _service.GoogleUser(dto));
        } 
        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDTO dto)
        {
            await _service.ForgotPassword(dto);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200, "Password reset link sent to your email", null);
        }

        [HttpPost("resetPassword")]
        public async Task<IActionResult> ResetPassword(string token, [FromBody] ResetPasswordDTO dto)
        {
            await _service.ResetPasswordAsync(token,dto);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200, "Password reset successfully", null);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
