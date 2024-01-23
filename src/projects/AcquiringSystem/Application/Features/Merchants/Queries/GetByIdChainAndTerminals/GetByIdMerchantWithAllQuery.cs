using MediatR;

namespace Application.Features.Merchants.Queries.GetByIdChainAndTerminals
{
    public sealed record GetByIdMerchantWithAllQuery(
        string id
        ):IRequest<GetByIdMerchantWithAllQueryResponse>;
}
