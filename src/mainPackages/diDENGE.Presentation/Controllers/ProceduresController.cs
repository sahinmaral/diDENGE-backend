using diDENGE.Application.Features.Procedures.Commands.AddOrUpdateProcedurePointInformations;
using diDENGE.Application.Features.Procedures.Queries.GetProcedurePointInformationsByUserId;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace diDENGE.Presentation.Controllers;

public class ProceduresController : BaseController
{
    [HttpGet("GetProcedurePointInformationsByUserId/{userId}")]
    public async Task<IActionResult> GetProcedurePointInformationsByUserId([FromRoute] string userId)
    {
        GetProcedurePointInformationsByUserIdQuery request = new GetProcedurePointInformationsByUserIdQuery()
        {
            UserId = userId
        };

        var response = await mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("AddOrUpdateProcedurePointInformations")]
    public async Task<IActionResult> AddOrUpdateProcedurePointInformations(
        [FromBody] AddOrUpdateProcedurePointInformationsCommand request)
    {
        var response = await mediator.Send(request);
        return Ok(response);
    }
}