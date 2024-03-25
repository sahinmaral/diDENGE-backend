using diDENGE.Application.Features.WordOfTheDays.Dtos;
using diDENGE.Application.Features.WordOfTheDays.Queries.GetByRandom;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace diDENGE.Presentation.Controllers;

public class WordOfTheDaysController : BaseController
{
    [HttpGet("GetByRandom")]
    public async Task<IActionResult> GetByRandomWordOfTheDay()
    {
        GetByRandomWordOfTheDayQuery request = new GetByRandomWordOfTheDayQuery();
        
        GetByRandomWordOfTheDayDto response = await mediator.Send(request);
        return Ok(response);
    }

}