using Application.Features.Chains.Models;
using Core.Application.Dtos;
using Core.Application.Responses;

namespace Application.Features.Chains.Queries.GetByIdWithMerchant
{
    public sealed record GetByIdWithMercantChainQueryResponse(
         string ChainCode,
         string TaxAdministration,
         string ChamberOfCommerce,
         string IdType,
         ICollection<MerchantDto> Merchants):IResponse;
}
