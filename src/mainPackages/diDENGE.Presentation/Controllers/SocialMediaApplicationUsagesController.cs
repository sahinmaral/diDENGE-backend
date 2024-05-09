using diDENGE.Application.Features.AddictionLevels.Commands.SaveAddictionLevelOfUser;
using diDENGE.Application.Features.AddictionLevels.Dtos;
using diDENGE.Application.Features.AddictionLevels.Queries.GetByUserId;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Commands.AddSocialMediaApplicationUsages;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Queries.GetSocialMediaApplicationUsagesByStartTime;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace diDENGE.Presentation.Controllers;

public class SocialMediaApplicationUsagesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> AddSocialMediaApplicationUsages([FromBody] AddSocialMediaApplicationUsagesCommand request)
    {
        await mediator.Send(request);
        return Ok();
    }

    [HttpGet("GetSocialMediaApplicationUsagesByStartTime")]
    public async Task<IActionResult> GetSocialMediaApplicationUsagesByStartTime(
        [FromQuery] GetSocialMediaApplicationUsagesByStartTimeQuery request)
    {
        var response = await mediator.Send(request);
        return Ok(response);
    }
}