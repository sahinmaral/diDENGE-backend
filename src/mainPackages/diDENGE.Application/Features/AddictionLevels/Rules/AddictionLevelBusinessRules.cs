using Core.CrossCuttingConcerns.Exceptions;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Features.AddictionLevels.Rules;

public class AddictionLevelBusinessRules(IAddictionLevelRepository repository)
{
    public async Task<AddictionLevel> CheckAddictionLevelById(string id)
    {
        AddictionLevel? foundAddictionLevel = await repository.GetAsync(predicate: queryable => queryable.Id == id);

        if (foundAddictionLevel is null)
            throw new EntityNotFoundException("Addiction level does not found");

        return foundAddictionLevel;
    }
}