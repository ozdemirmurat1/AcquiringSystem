using Core.Application.Responses;

namespace Application.Features.Merchants.Queries.GetById
{
    public sealed record GetByIdMerchantQueryResponse(
        string MerchantNumber,
        string MerchantName,
        string Province,
        string District,
        string Address,
        string Email,
        string TelephoneNumber,
        string ChainId
        ) :IResponse;
}
