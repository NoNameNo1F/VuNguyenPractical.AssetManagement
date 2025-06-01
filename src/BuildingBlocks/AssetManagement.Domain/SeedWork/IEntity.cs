namespace AssetManagement.Domain.SeedWork;

public interface IEntity<TKey>
{
    TKey Id { get; }
}