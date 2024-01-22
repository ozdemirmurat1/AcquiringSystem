using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Chains.Queries.GetList
{
    public sealed class GetListChainQuery : IRequest<GetListResponse<GetListChainQueryResponse>>
    {
        public PageRequest PageRequest { get; set; }
    }
    
}
