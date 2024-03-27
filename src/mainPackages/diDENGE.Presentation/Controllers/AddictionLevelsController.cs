using diDENGE.Application.Features.AddictionLevels.Commands.SaveAddictionLevelOfUser;
using diDENGE.Application.Features.AddictionLevels.Dtos;
using diDENGE.Application.Features.AddictionLevels.Queries.GetByUserId;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace diDENGE.Presentation.Controllers;

public class AddictionLevelsController : BaseController
{
    [HttpPost("SaveAddictionLevelOfUser")]
    public async Task<IActionResult> SaveAddictionLevelOfUser([FromBody] SaveAddictionLevelOfUserCommand request)
    {
        SavedUserAddictionLevelDto response = await mediator.Send(request);
        return Created("", response);
    }
    
    [HttpGet("GetByUserId/{userId}")]
    public async Task<IActionResult> GetAddictionLevelByUserId([FromRoute]string userId)
    {
        GetByUserIdQuery request = new GetByUserIdQuery()
        {
            UserId = userId
        };
        GetAddictionLevelByUserIdDto response = await mediator.Send(request);
        return Ok(response);
    }

}