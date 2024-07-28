using diDENGE.Application.Features.Users.Commands.ContactUs;
using diDENGE.Application.Features.Users.Commands.DeleteProfileImage;
using diDENGE.Application.Features.Users.Commands.UpdateDoNotDisturbStatus;
using diDENGE.Application.Features.Users.Commands.UpdateNameSurname;
using diDENGE.Application.Features.Users.Commands.UpdatePassword;
using diDENGE.Application.Features.Users.Commands.UpdateProfileImage;
using diDENGE.Application.Features.Users.Dtos;
using diDENGE.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace diDENGE.Presentation.Controllers;

public class UsersController : BaseController
{
    
    [HttpPut("UpdateNameSurname/{userId}")]
    public async Task<IActionResult> UpdateNameSurname([FromRoute]string userId, [FromBody] UpdateNameSurnameCommandBodyDto body)
    {
        UpdateNameSurnameCommand request = new UpdateNameSurnameCommand()
        {
            Body = body,
            UserId = userId
        };
        await mediator.Send(request);
        
        return NoContent();
    }
    
    
    [HttpPut("UpdatePassword/{userId}")]
    public async Task<IActionResult> UpdatePassword([FromRoute]string userId, [FromBody] UpdatePasswordCommandBodyDto body)
    {
        UpdatePasswordCommand request = new UpdatePasswordCommand()
        {
            Body = body,
            UserId = userId
        };
        await mediator.Send(request);
        
        return NoContent();
    }
    
    
    [HttpPut("UpdateProfileImage/{userId}")]
    public async Task<IActionResult> UpdateProfileImage([FromRoute]string userId, IFormFile image)
    {
        UpdateProfileImageCommand request = new UpdateProfileImageCommand()
        {
            Image = image,
            UserId = userId
        };
        UpdatedProfileImageDto response = await mediator.Send(request);
        
        return Ok(response);
    }
    
    [HttpDelete("DeleteProfileImage/{userId}")]
    public async Task<IActionResult> DeleteProfileImage([FromRoute]string userId)
    {
        DeleteProfileImageCommand request = new DeleteProfileImageCommand()
        {
            UserId = userId
        };
        await mediator.Send(request);
        
        return NoContent();
    }
    
    [HttpPut("UpdateDoNotDisturbStatus/{userId}")]
    public async Task<IActionResult> UpdateDoNotDisturbStatus([FromRoute]string userId, [FromBody] UpdateDoNotDisturbStatusCommandBodyDto body)
    {
        UpdateDoNotDisturbStatusCommand request = new UpdateDoNotDisturbStatusCommand()
        {
            Body = body,
            UserId = userId
        };
        await mediator.Send(request);
        
        return NoContent();
    }
    
    [HttpPost("ContactUs")]
    public async Task<IActionResult> ContactUs([FromBody] ContactUsCommand request)
    {
        await mediator.Send(request);
        
        return Ok();
    }

}