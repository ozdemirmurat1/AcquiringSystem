using MediatR;

namespace Application.Features.Terminals.Queries.GetByIdTerminalWithMerchant
{
    public sealed record GetByIdTerminalWithMerchantQuery(
        string id
        ):IRequest<GetByIdTerminalWithMerchantQueryResponse>;
}
