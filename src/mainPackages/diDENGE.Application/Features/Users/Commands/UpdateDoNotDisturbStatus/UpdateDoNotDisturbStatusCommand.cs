using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.Users.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace diDENGE.Application.Features.Users.Commands.UpdateDoNotDisturbStatus;


public class UpdateDoNotDisturbStatusCommand : IRequest, ISecuredRequest
{
    public string[] Roles => ["User"];
    public string UserId { get; set; }
    public UpdateDoNotDisturbStatusCommandBodyDto Body { get; set; }
    
    public class UpdateDoNotDisturbStatusCommandHandler(UserManager<User> userManager, AuthBusinessRules authBusinessRules) : IRequestHandler<UpdateDoNotDisturbStatusCommand>
    {
        public async Task Handle(UpdateDoNotDisturbStatusCommand request, CancellationToken cancellationToken)
        {
            User updatedUser = await authBusinessRules.CheckUserExistsById(request.UserId);

            updatedUser.IsDoNotDisturbEnabled = request.Body.IsDoNotDisturbEnabled;
            updatedUser.DoNotDisturbExpires =
                !request.Body.IsDoNotDisturbEnabled ? null : request.Body.DoNotDisturbExpires;

            await userManager.UpdateAsync(updatedUser);
        }
    }
}