namespace diDENGE.Application.Services.Repositories;

public interface IUnitOfWork : IDisposable
{
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
    Task ExecuteAsync(Func<Task> operation);
}