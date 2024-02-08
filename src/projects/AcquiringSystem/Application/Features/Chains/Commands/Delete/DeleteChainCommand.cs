using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Chains.Constants.ChainsOperationClaims;

namespace Application.Features.Chains.Commands.Delete
{
    public sealed record DeleteChainCommand(
        string id) : IRequest<DeleteChainCommandResponse>, ISecuredRequest
    {
        public string[] Roles => new[] { ChainDelete };
    }
}
