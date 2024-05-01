using AutoMapper;
using Core.Persistence.Paging;
using diDENGE.Application.Features.Procedures.Dtos;
using diDENGE.Application.Features.Procedures.Models;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Features.Procedures.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProcedurePointInformation, GetProcedurePointInformationsByUserIdListItemDto>();
        CreateMap<IPaginate<ProcedurePointInformation>, GetProcedurePointInformationsByUserIdListModel>().ReverseMap();
        
        CreateMap<ProcedurePointInformation, AddOrUpdateProcedurePointInformationDto>();

        CreateMap<Procedure, GetProcedurePointInformationsByUserIdListItemProcedureDto>();
        CreateMap<Procedure, AddOrUpdateProcedurePointInformationProcedureDto>();
    }
}