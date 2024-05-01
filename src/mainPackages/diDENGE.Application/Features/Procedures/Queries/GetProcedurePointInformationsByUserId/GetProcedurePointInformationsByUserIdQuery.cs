using AutoMapper;
using diDENGE.Application.Features.Procedures.Models;
using diDENGE.Application.Services.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Application.Features.Procedures.Queries.GetProcedurePointInformationsByUserId;

public class GetProcedurePointInformationsByUserIdQuery : IRequest<GetProcedurePointInformationsByUserIdListModel>
{
    public string UserId { get; set; }

    public class GetProcedurePointInformationsByUserIdQueryHandler(
        IProcedurePointInformationRepository repository,
        IMapper mapper) : IRequestHandler<
        GetProcedurePointInformationsByUserIdQuery, GetProcedurePointInformationsByUserIdListModel>
    {
        public async Task<GetProcedurePointInformationsByUserIdListModel> Handle(GetProcedurePointInformationsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var procedures = await repository.GetListAsync(
                predicate: queryable => queryable.UserId == request.UserId,
                include: queryable => queryable.Include(information => information.Procedure),
                size: 15,
                cancellationToken: cancellationToken);
            return mapper.Map<GetProcedurePointInformationsByUserIdListModel>(procedures);
        }
    }
}