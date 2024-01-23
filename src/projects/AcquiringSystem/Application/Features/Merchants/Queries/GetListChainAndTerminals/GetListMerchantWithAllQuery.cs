using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Merchants.Queries.GetListChainAndTerminals
{
    public sealed class GetListMerchantWithAllQuery:IRequest<GetListResponse<GetListMerchantWithAllQueryResponse>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
