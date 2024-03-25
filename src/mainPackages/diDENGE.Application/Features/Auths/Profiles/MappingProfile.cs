using AutoMapper;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Commands.RegisterUser;
using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Features.Auths.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterUserCommand, User>();
        CreateMap<User, RegisteredUserDto>();

        CreateMap<User, LoggedUserDto>();

        CreateMap<UserAddictionLevel, LoggedUserAddictionLevelDto>()
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