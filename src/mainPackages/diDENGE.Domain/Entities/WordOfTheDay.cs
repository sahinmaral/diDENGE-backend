using Core.Persistence.Repositories;

namespace diDENGE.Domain.Entities;

public class WordOfTheDay : Entity
{
    public string Content { get; set; }
}