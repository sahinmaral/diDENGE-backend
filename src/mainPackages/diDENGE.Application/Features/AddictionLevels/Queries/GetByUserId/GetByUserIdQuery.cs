using AutoMapper;
using diDENGE.Application.Features.AddictionLevels.Dtos;
using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Application.Services.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Application.Features.AddictionLevels.Queries.GetByUserId;

public class GetByUserIdQuery : IRequest<GetAddictionLevelByUserIdDto>
{
    public string UserId { get; set; }

    public class GetByUserIdQueryHandler(IUserAddictionLevelRepository userAddictionLevelRepository, IMapper mapper)
        : IRequestHandler<GetByUserIdQuery, GetAddictionLevelByUserIdDto>
    {

        public async Task<GetAddictionLevelByUserIdDto> Handle(GetByUserIdQuery request, CancellationToken cancellationToken)
        {
            var userAddictionLevel = await userAddictionLevelRepository.GetDetailedAsync(
                predicate:x => x.UserId == request.UserId,
                include: levels => levels.Include(l => l.AddictionLevel) 
            );
            return mapper.Map<GetAddictionLevelByUserIdDto>(userAddictionLevel);
        }
    }
}