using Core.Application.Responses;

namespace Application.Features.Merchants.Queries.GetList
{
    public sealed record GetListMerchantQueryResponse(
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
