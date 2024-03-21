using diDENGE.Application.Features.AddictionLevels.Commands.SaveAddictionLevelOfUser;
using diDENGE.Application.Features.AddictionLevels.Dtos;
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

}