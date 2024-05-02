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

        CreateMap<UserAddictionLevel, GetAddictionLevelByUserIdDto>()
            .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => src.AddictionLevelId)
            )
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.AddictionLevel.Name)
            )
            .ForMember(
                dest => dest.DailyLimit,
                opt => opt.MapFrom(src => src.AddictionLevel.DailyLimit)
            )
            .ForMember(
                dest => dest.MaximumGrade,
                opt => opt.MapFrom(src => src.AddictionLevel.MaximumGrade)
            )
            .ForMember(
                dest => dest.MinimumGrade,
                opt => opt.MapFrom(src => src.AddictionLevel.MinimumGrade)
            );
    }
}