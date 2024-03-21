using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using diDENGE.Application.Features.AddictionLevels.Constants;
using diDENGE.Application.Features.AddictionLevels.Dtos;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Application.Features.AddictionLevels.Commands.SaveAddictionLevelOfUser;

public class SaveAddictionLevelOfUserCommand : IRequest<SavedUserAddictionLevelDto>, ISecuredRequest
{
    public string[] Roles => new[] { "User" };
    public string UserId { get; set; }
    public double Grade { get; set; }
    
    public class SaveAddictionLevelOfUserCommandHandler(
        IAddictionLevelRepository addictionLevelRepository,
        AuthBusinessRules authBusinessRules,
        IUserAddictionLevelRepository userAddictionLevelRepository,
        UserManager<User> userManager,
        IMapper mapper)
        : IRequestHandler<SaveAddictionLevelOfUserCommand, SavedUserAddictionLevelDto>
    {
        public async Task<SavedUserAddictionLevelDto> Handle(SaveAddictionLevelOfUserCommand request, CancellationToken cancellationToken)
        {
            await authBusinessRules.CheckUserExistsById(request.UserId);

            var allSavedDeterminedAddictionLevelsOfUser = await userAddictionLevelRepository.GetListAsync(x => x.UserId == request.UserId,
                orderBy: qual => qual.OrderByDescending(ual => ual.CreatedAt));

            var determinedAddictionLevel = await addictionLevelRepository.GetAsync(x =>
                x.MinimumGrade < request.Grade && x.MaximumGrade > request.Grade);
            
            if (allSavedDeterminedAddictionLevelsOfUser.Items.Count == 0)
            {
                var addedUserAddictionLevel = await userAddictionLevelRepository.AddAsync(
                    new UserAddictionLevel()
                    {
                        UserId = request.UserId,
                        AddictionLevelId = determinedAddictionLevel.Id,
                        Grade = request.Grade
                    }
                );

                var foundUser = (await userManager.FindByIdAsync(request.UserId))!;
                foundUser.IsNewUser = false;
                await userManager.UpdateAsync(foundUser);
                
                var newUserAddictionLevel =  await userAddictionLevelRepository.GetDetailedAsync(
                    predicate: x => x.Id == addedUserAddictionLevel.Id,
                    include: qal => qal.Include(al => al.AddictionLevel)
                );
                
                return mapper.Map<SavedUserAddictionLevelDto>(newUserAddictionLevel);
            }
            else
            {
                var lastDeterminedAddictionLevelOfUser = allSavedDeterminedAddictionLevelsOfUser.Items.First();
                var intervalOfLastDeterminedAddictionLevel =
                    (DateTime.Now - lastDeterminedAddictionLevelOfUser.CreatedAt).TotalDays;
                if (Convert.ToInt16(intervalOfLastDeterminedAddictionLevel) != AddictionLevelConstants.UserAddictionLevelIdentificationDayInterval)
                {
                    throw new BusinessException($"There must be {AddictionLevelConstants.UserAddictionLevelIdentificationDayInterval} days between the last addiction level determination");
                }
                
                var addedUserAddictionLevel = await userAddictionLevelRepository.AddAsync(
                    new UserAddictionLevel()
                    {
                        UserId = request.UserId,
                        AddictionLevelId = determinedAddictionLevel.Id,
                        Grade = request.Grade
                    }
                );

                var newUserAddictionLevel =  await userAddictionLevelRepository.GetDetailedAsync(
                    predicate: x => x.Id == addedUserAddictionLevel.Id,
                    include: qal => qal.Include(al => al.AddictionLevel)
                );

                return mapper.Map<SavedUserAddictionLevelDto>(newUserAddictionLevel);
            }
            

        }
    }

    
}