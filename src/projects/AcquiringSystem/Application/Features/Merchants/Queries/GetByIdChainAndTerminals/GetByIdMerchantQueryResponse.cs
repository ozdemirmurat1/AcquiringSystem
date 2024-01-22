using Application.Features.Merchants.Models;
using Core.Application.Responses;

namespace Application.Features.Merchants.Queries.GetByIdChainAndTerminals
{
    public sealed record GetByIdMerchantQueryResponse(
        string MerchantNumber,
        string MerchantName,
        string Province,
        string District,
        string Address,
        string Email,
        string TelephoneNumber,
        string ChainId,
        ChainDto Chain,
        ICollection<TerminalDto> Terminals
        ) :IResponse;
}
