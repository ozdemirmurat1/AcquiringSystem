using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Merchants.Queries.GetList
{
    public sealed class GetListMerchantQuery : IRequest<GetListResponse<GetListMerchantQueryResponse>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
