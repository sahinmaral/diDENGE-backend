using diDENGE.Application.Features.AddictionLevels.Commands.SaveAddictionLevelOfUser;
using diDENGE.Application.Features.AddictionLevels.Dtos;
using diDENGE.Application.Features.AddictionLevels.Queries.GetByUserId;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Commands.AddSocialMediaApplicationUsages;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Queries.GetSocialMediaApplicationUsagesByStartAndEndTime;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Queries.GetSocialMediaApplicationUsagesByStartAndEndTime;
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

    [HttpGet("GetSocialMediaApplicationUsagesByStartAndEndTime")]
    public async Task<IActionResult> GetSocialMediaApplicationUsagesByStartAndEndTime(
        [FromQuery] GetSocialMediaApplicationUsagesByStartAndEndTimeQuery request)
    {
        var response = await mediator.Send(request);
        return Ok(response);
    }
}