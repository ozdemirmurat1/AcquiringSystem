using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;
using static Application.Features.Chains.Constants.ChainsOperationClaims;

namespace Application.Features.Chains.Queries.GetList
{
    public sealed class GetListChainQuery : IRequest<ResponseDto<GetListResponse<GetListChainQueryResponse>>>,ISecuredRequest
    {
        public PageRequest PageRequest { get; set; }

        public string[] Roles => new[] {Admin, Read };
    }
    
}
