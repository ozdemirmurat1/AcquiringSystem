using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Terminals.Queries.GetListTerminalWithMerchant
{
    public sealed class GetListTerminalWithMerchantQuery : IRequest<GetListResponse<GetListTerminalWithMerchantQueryResponse>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
