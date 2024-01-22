using MediatR;

namespace Application.Features.Chains.Queries.GetById
{
    public sealed record GetByIdChainQuery(
        string id):IRequest<GetByIdChainQueryResponse>;
}
