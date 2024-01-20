using MediatR;

namespace Application.Features.Chains.Commands.Create
{
    public sealed record CreateChainCommand(
         string id,
         string ChainCode,
         string TaxAdministration,
         string ChamberOfCommerce,
         string IdType ) : IRequest<CreateChainCommandResponse>;
}
