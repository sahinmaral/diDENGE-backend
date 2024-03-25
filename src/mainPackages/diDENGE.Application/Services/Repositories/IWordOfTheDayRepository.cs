using Core.Persistence.Repositories;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Services.Repositories;

public interface IWordOfTheDayRepository : IAsyncRepository<WordOfTheDay>, IRepository<WordOfTheDay>
{
    Task<WordOfTheDay?> GetRandomWordOfTheDayAsync();
    WordOfTheDay? GetRandomWordOfTheDay();
}