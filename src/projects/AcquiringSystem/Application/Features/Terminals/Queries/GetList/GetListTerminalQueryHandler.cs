using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Terminals.Queries.GetList
{
    public sealed class GetListTerminalQueryHandler : IRequestHandler<GetListTerminalQuery, GetListResponse<GetListTerminalQueryResponse>>
    {
        private readonly ITerminalRepository _terminalRepoitory;
        private readonly IMapper _mapper;

        public GetListTerminalQueryHandler(ITerminalRepository terminalRepoitory, IMapper mapper)
        {
            _terminalRepoitory = terminalRepoitory;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListTerminalQueryResponse>> Handle(GetListTerminalQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Terminal> terminals = await _terminalRepoitory.GetListAsync(
               index: request.PageRequest.PageIndex,
               size: request.PageRequest.PageSize,
               cancellationToken: cancellationToken);

            GetListResponse<GetListTerminalQueryResponse> response = _mapper.Map<GetListResponse<GetListTerminalQueryResponse>>(terminals);

            return response;
        }
    }
}
