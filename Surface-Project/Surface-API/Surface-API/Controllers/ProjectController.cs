using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Surface.API.Utils;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Project;
using Surface_Entities.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Surface_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _service;
        public ProjectController(IProjectService service)
        {
            _service = service;

        }


        [HttpPost("upsertProject")]
        public async Task<IActionResult> UpsertProject(UpsertProjectDTO dto)
        {
            await _service.UpsertProject(dto);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200, "Project Created successfully", null);
        }

        [HttpPatch("patchProject")]
        public async Task<IActionResult> UpdateProject([FromQuery] long Id, [FromBody] JsonPatchDocument<Project> dto)
        {
            if (dto != null)
            {
                Project projectToUpdate = await _service.GetById(Id);

                dto.ApplyTo(projectToUpdate, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                await _service.SaveAsync();
                return new SuccessResponseHelper<object>().GetSuccessResponse(200, "Project Created successfully", null);


            }
            return Ok();

        }


    }
}
