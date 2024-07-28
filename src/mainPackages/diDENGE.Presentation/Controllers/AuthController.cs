using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;
using diDENGE.Application.Features.Auths.Commands.LoginUser;
using diDENGE.Application.Features.Auths.Commands.RegisterUser;
using diDENGE.Application.Features.Auths.Commands.SendVerificationCode;
using diDENGE.Application.Features.Auths.Commands.VerifyVerificationCode;

namespace diDENGE.Presentation.Controllers;

public class AuthController : BaseController
{
    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserCommand request)
    {
        RegisterUserResponseDto response = await mediator.Send(request);
        return Created("", response);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUserCommand request)
    {
        LoggedUserDto response = await mediator.Send(request);
        return Ok(response);
    }
    
    [HttpPost("SendVerificationCode")]
    public async Task<IActionResult> SendVerificationCode([FromBody] SendVerificationCodeCommand request)
    {
        await mediator.Send(request);
        return Ok();
    }
    
    [HttpPost("VerifyVerificationCode")]
    public async Task<IActionResult> VerifyVerificationCode([FromBody] VerifyVerificationCodeCommand request)
    {
        await mediator.Send(request);
        return Ok();
    }
}