using MediatR;

namespace Application.Features.Chains.Commands.Delete
{
    public sealed record DeleteChainCommand(
        string id):IRequest<DeleteChainCommandResponse>;
}
