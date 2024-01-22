using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Chains.Queries.GetListWithMerchant
{
    public sealed class GetListWithMerchantChainQuery : IRequest<GetListResponse<GetListWithMerchantChainQueryResponse>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
