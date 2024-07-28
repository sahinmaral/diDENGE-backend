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

        CreateMap<User, LoggedUserDto>();
    }
}