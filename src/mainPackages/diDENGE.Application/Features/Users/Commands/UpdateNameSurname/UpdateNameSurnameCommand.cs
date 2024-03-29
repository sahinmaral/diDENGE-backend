using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.Users.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace diDENGE.Application.Features.Users.Commands.UpdateNameSurname;

public class UpdateNameSurnameCommand : IRequest, ISecuredRequest
{
    public string[] Roles => ["User"];
    public string UserId { get; set; }
    public UpdateNameSurnameCommandBodyDto Body { get; set; }
    
    public class UpdateNameSurnameCommandHandler(UserManager<User> userManager, AuthBusinessRules authBusinessRules) : IRequestHandler<UpdateNameSurnameCommand>
    {
        public async Task Handle(UpdateNameSurnameCommand request, CancellationToken cancellationToken)
        {
            User updatedUser = await authBusinessRules.CheckUserExistsById(request.UserId);

            updatedUser.FirstName = request.Body.FirstName;
            updatedUser.MiddleName = request.Body.MiddleName;
            updatedUser.LastName = request.Body.LastName;

            await userManager.UpdateAsync(updatedUser);
        }
    }
}