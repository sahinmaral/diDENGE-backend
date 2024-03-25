using AutoMapper;
using diDENGE.Application.Features.WordOfTheDays.Dtos;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Features.WordOfTheDays.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<WordOfTheDay, GetByRandomWordOfTheDayDto>();
    }
}