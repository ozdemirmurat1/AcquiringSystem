using Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Chains.Constants.ChainsOperationClaims;

namespace Application.Features.Chains.Queries.GetById
{
    public sealed record GetByIdChainQuery(
        string id) : IRequest<GetByIdChainQueryResponse>, ISecuredRequest
    {
        public string[] Roles => new[] { Admin,Read };
    }
}
