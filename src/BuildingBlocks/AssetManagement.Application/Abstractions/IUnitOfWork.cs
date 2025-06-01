namespace AssetManagement.Application.Abstractions;

public interface IUnitOfWork
{
    Task<int> CommitAsync(CancellationToken cancellation);
}