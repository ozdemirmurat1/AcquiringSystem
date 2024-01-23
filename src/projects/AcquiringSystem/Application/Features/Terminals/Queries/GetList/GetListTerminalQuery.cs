using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Terminals.Queries.GetList
{
    public sealed class GetListTerminalQuery : IRequest<GetListResponse<GetListTerminalQueryResponse>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
