using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Persistance.Repositories;

public sealed class WordOfTheDayRepository :  EfRepositoryBase<WordOfTheDay, AppDbContext>, IWordOfTheDayRepository
{
    private readonly AppDbContext _context;

    public WordOfTheDayRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
    
    public Task<WordOfTheDay> GetRandomWordOfTheDayAsync()
    {
        var wordOfTheDaysTable = _context.Set<WordOfTheDay>();
        Random random = new Random();
        int count = wordOfTheDaysTable.Count();
        int randomIndex = random.Next(0, count);
        
        return wordOfTheDaysTable.OrderBy(w => w.Id).Skip(randomIndex).FirstOrDefaultAsync();
    }
    
    public WordOfTheDay GetRandomWordOfTheDay()
    {
        var wordOfTheDaysTable = _context.Set<WordOfTheDay>();
        Random random = new Random();
        int count = wordOfTheDaysTable.Count();
        int randomIndex = random.Next(0, count);
        
        return wordOfTheDaysTable.OrderBy(w => w.Id).Skip(randomIndex).FirstOrDefault()!;
    }
}