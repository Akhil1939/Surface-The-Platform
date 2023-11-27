using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Surface.API.Utils;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Project;
using Surface_Entities.Entities;


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

        [HttpPost("Add")]
        public async Task<IActionResult> Add(UpsertProjectDTO dto)
        {
            await _service.Add(dto);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200, "Project Created successfully", null);
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update([FromQuery] long Id, [FromBody] JsonPatchDocument<Project> dto)
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
        [HttpDelete ("Delete")]
        public async Task<IActionResult> DeleteProject(long id)
        {
            await _service.DeleteProject(id);
            return new SuccessResponseHelper<object>().GetSuccessResponse(200, "Project Deleted successfully", null);

        }
    }
}
