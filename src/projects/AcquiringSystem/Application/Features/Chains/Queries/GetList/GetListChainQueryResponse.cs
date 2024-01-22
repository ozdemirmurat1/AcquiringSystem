using Core.Application.Dtos;

namespace Application.Features.Chains.Queries.GetList
{
    public sealed record GetListChainQueryResponse(
        string ChainCode,
         string TaxAdministration,
         string ChamberOfCommerce,
         string IdType):IDto;
}
