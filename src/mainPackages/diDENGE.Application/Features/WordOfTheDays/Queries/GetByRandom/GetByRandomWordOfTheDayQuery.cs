using AutoMapper;
using diDENGE.Application.Services.Repositories;
using diDENGE.Application.Features.WordOfTheDays.Dtos;
using MediatR;

namespace diDENGE.Application.Features.WordOfTheDays.Queries.GetByRandom;

public class GetByRandomWordOfTheDayQuery : IRequest<GetByRandomWordOfTheDayDto>
{
    public class GetByRandomWordOfTheDayQueryHandler : IRequestHandler<GetByRandomWordOfTheDayQuery, GetByRandomWordOfTheDayDto>
    {
        private readonly IMapper _mapper;
        private readonly IWordOfTheDayRepository _wordOfTheDayRepository;

        public GetByRandomWordOfTheDayQueryHandler(IMapper mapper, IWordOfTheDayRepository wordOfTheDayRepository)
        {
            _mapper = mapper;
            _wordOfTheDayRepository = wordOfTheDayRepository;
        }

        public async Task<GetByRandomWordOfTheDayDto> Handle(GetByRandomWordOfTheDayQuery request, CancellationToken cancellationToken)
        {
            var randomWordOfTheDay = await _wordOfTheDayRepository.GetRandomWordOfTheDayAsync();
            return _mapper.Map<GetByRandomWordOfTheDayDto>(randomWordOfTheDay);
        }
    }
}