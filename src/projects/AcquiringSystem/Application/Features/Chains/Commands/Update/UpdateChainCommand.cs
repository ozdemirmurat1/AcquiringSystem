using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Chains.Constants.ChainsOperationClaims;

namespace Application.Features.Chains.Commands.Update
{
    public sealed record UpdateChainCommand(
        string id,
        string ChainCode,
        string TaxAdministration,
        string ChamberOfCommerce,
        string IdType) : IRequest<UpdateChainCommandResponse>, ISecuredRequest
    {
        public string[] Roles => new[] { ChainUpdate };
    }
}
