using diDENGE.Application.Features.AddictionLevels.Rules;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Dtos;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using MediatR;

namespace diDENGE.Application.Features.SocialMediaApplicationUsages.Commands.AddSocialMediaApplicationUsages;

public class AddSocialMediaApplicationUsagesCommand : IRequest
{
    public string UserId { get; set; }
    public string AddictionLevelId { get; set; }

    public List<AddSocialMediaApplicationUsageDto> SocialMediaApplicationUsages { get; set; } =
        new List<AddSocialMediaApplicationUsageDto>();
    
    public class AddSocialMediaApplicationUsagesCommandHandler(
        AuthBusinessRules authBusinessRules,
        AddictionLevelBusinessRules addictionLevelBusinessRules,
        ISocialMediaApplicationUsageRepository socialMediaApplicationUsageRepository,
        ISocialMediaApplicationRepository socialMediaApplicationRepository)
        : IRequestHandler<AddSocialMediaApplicationUsagesCommand>
    {
        public async Task Handle(AddSocialMediaApplicationUsagesCommand request, CancellationToken cancellationToken)
        {
            await authBusinessRules.CheckUserExistsById(request.UserId);
            await addictionLevelBusinessRules.CheckAddictionLevelById(request.AddictionLevelId);
            
            var count = await socialMediaApplicationRepository.CountAsync();
            var allSocialMediaApplications  = (await socialMediaApplicationRepository.GetListAsync(cancellationToken: cancellationToken, size: count)).Items;

            foreach (var socialMediaApplication in allSocialMediaApplications)
            {
                var foundSocialMediaApplicationUsage = request.SocialMediaApplicationUsages.FirstOrDefault(predicate: queryable =>
                    queryable.PackageName == socialMediaApplication.PlaystoreId);
                
                // FIX: Herhangi bir hata surecinde bu islemlerin geri alinmasi gerekir.
                
                if (foundSocialMediaApplicationUsage is null)
                {
                    var newSocialMediaApplicationUsage = new SocialMediaApplicationUsage
                    {
                        UserId = request.UserId,
                        AddictionLevelId = request.AddictionLevelId,
                        SocialMediaApplicationId = socialMediaApplication.Id,
                        SpentTime = 0,
                        OpeningCount = 0
                    };

                    socialMediaApplicationUsageRepository.Add(newSocialMediaApplicationUsage);
                }
                else
                {
                    var newSocialMediaApplicationUsage = new SocialMediaApplicationUsage
                    {
                        UserId = request.UserId,
                        AddictionLevelId = request.AddictionLevelId,
                        SocialMediaApplicationId = socialMediaApplication.Id,
                        SpentTime = foundSocialMediaApplicationUsage.TotalTimeInForeground,
                        OpeningCount = foundSocialMediaApplicationUsage.OpenCount
                    };
                    
                    socialMediaApplicationUsageRepository.Add(newSocialMediaApplicationUsage);
                }
            }
        }
    }
}