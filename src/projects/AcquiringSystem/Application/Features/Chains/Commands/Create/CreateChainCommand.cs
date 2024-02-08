using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Chains.Constants.ChainsOperationClaims;

namespace Application.Features.Chains.Commands.Create
{
    public sealed record CreateChainCommand(
         string ChainCode,
         string TaxAdministration,
         string ChamberOfCommerce,
         string IdType) : IRequest<CreateChainCommandResponse>, ISecuredRequest
    {
        public string[] Roles => new[] { ChainAdd };
    }
}
