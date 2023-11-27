using Microsoft.AspNetCore.Mvc;
using Surface.API.Utils;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Team;
using Surface_Entities.DTOs.Team_Member;

namespace Surface_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly ITeamService _service;
        public TeamController(ITeamService service)
        {
            _service = service;
        }

        // GET api/<TeamController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {

            return new SuccessResponseHelper<TeamDTO>().GetSuccessResponse(200, "Success", await _service.GetTeam(id));

        }

        // POST api/<TeamController>
        [HttpPost("create")]
        public async Task<IActionResult> Add([FromBody] TeamDTO dto)
        {
            await _service.Upsert(dto);
            return new SuccessResponseHelper<TeamDTO>().GetSuccessResponse(200, "Team Added", null);
        }

        //PUT api/<TeamController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TeamDTO dto)
        {
            await _service.Upsert(dto);
            return new SuccessResponseHelper<TeamDTO>().GetSuccessResponse(200, "Team Updated", null);
        }

        // DELETE api/<TeamController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _service.Delete(id);
            return new SuccessResponseHelper<TeamDTO>().GetSuccessResponse(200, "Team Deleted", null);

        }
        [HttpPost("Invite-TeamMember")]
        public async Task<IActionResult> InviteTeam(List<TeamInviteRequestDTO> Invites, long TeamId){
            await _service.InviteTeamMember(Invites, TeamId);
            return new SuccessResponseHelper<TeamDTO>().GetSuccessResponse(200, "Team Invites sends", null);
        }

    }
}
