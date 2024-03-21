using AutoMapper;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Commands.RegisterUser;
using diDENGE.Application.Features.Auths.Dtos;

namespace diDENGE.Application.Features.Auths.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterUserCommand, User>();
        CreateMap<User, RegisteredUserDto>();

        CreateMap<User, LoggedUserDto>();
    }
}