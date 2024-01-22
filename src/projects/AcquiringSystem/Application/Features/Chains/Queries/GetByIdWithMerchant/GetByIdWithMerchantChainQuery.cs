using MediatR;

namespace Application.Features.Chains.Queries.GetByIdWithMerchant
{
    public sealed record GetByIdWithMerchantChainQuery(
        string id) : IRequest<GetByIdWithMercantChainQueryResponse>;
}
