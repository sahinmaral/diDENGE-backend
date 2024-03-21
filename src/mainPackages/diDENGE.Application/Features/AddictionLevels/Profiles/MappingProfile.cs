using AutoMapper;
using diDENGE.Application.Features.AddictionLevels.Dtos;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Features.AddictionLevels.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserAddictionLevel, SavedUserAddictionLevelDto>();
        CreateMap<AddictionLevel, AddictionLevelOfSavedUserAddictionLevelDto>();

    }
}