namespace AssetManagement.Domain.SeedWork;

public interface IDomainEvent
{
    Guid Id { get; set; }
    DateTime OccurredOn { get; set; }
}