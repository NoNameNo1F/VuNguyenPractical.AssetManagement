using MediatR;

namespace AssetManagement.Application.Contracts;

public interface ICommand : IRequest
{
}

public interface ICommand<TResponse> : IRequest<TResponse>
{
}
