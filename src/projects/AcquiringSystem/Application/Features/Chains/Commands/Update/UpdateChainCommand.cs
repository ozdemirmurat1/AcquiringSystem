using MediatR;

namespace Application.Features.Chains.Commands.Update
{
    public sealed record UpdateChainCommand(
        string id,
        string ChainCode,
        string TaxAdministration,
        string ChamberOfCommerce,
        string IdType) : IRequest<UpdateChainCommandResponse>;
}
