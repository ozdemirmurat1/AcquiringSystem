using MediatR;

namespace Application.Features.Merchants.Queries.GetByIdChainAndTerminals
{
    public sealed record GetByIdMerchantQuery(
        string id
        ):IRequest<GetByIdMerchantQueryResponse>;
}
