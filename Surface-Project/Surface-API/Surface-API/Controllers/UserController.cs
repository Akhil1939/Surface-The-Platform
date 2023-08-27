using Microsoft.AspNetCore.Mvc;
using Surface.API.Utils;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Surface_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
            
        }
        // GET: api/<UserController>

        [HttpPost("add")]
        public async Task<IActionResult> Post([FromBody] RegisterDTO dto)
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

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
