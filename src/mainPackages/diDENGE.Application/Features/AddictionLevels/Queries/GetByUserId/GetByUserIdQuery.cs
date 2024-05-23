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
            var userAddictionLevels = await userAddictionLevelRepository.GetListAsync(
                predicate:x => x.UserId == request.UserId,
                orderBy: queryable => queryable.OrderByDescending(x => x.CreatedAt), 
                include: levels => levels.Include(l => l.AddictionLevel), cancellationToken: cancellationToken);

            var latestAddictionLevel = userAddictionLevels.Items.FirstOrDefault();
            
            return mapper.Map<GetAddictionLevelByUserIdDto>(latestAddictionLevel);
        }
    }
}