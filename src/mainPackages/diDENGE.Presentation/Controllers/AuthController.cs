using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;
using diDENGE.Application.Features.Auths.Commands.LoginUser;
using diDENGE.Application.Features.Auths.Commands.RegisterUser;

namespace diDENGE.Presentation.Controllers;

public class AuthController : BaseController
{
    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserCommand request)
    {
        RegisteredUserDto response = await mediator.Send(request);
        return Created("", response);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUserCommand request)
    {
        LoggedUserDto response = await mediator.Send(request);
        return Ok(response);
    }
    
}