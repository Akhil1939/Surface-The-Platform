using Microsoft.AspNetCore.Mvc;
using Surface.API.Utils;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Surface_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IUserService _service;
        public ServiceController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{query}")]
        public async Task<IActionResult> GetEmailList(string query)
        {

            return new SuccessResponseHelper<List<EmailDTO>>().GetSuccessResponse(200, "Email List", await _service.GetEmailList(query));
        }

        
    }
}
