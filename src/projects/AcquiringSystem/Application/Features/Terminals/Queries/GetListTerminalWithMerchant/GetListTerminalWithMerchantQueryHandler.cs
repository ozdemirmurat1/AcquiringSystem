using Application.Features.Terminals.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Terminals.Queries.GetListTerminalWithMerchant
{
    public sealed class GetListTerminalWithMerchantQueryHandler : IRequestHandler<GetListTerminalWithMerchantQuery, GetListResponse<GetListTerminalWithMerchantQueryResponse>>
    {
        private readonly ITerminalRepository _terminalRepoitory;
        private readonly IMapper _mapper;

        public GetListTerminalWithMerchantQueryHandler(ITerminalRepository terminalRepoitory, IMapper mapper)
        {
            _terminalRepoitory = terminalRepoitory;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListTerminalWithMerchantQueryResponse>> Handle(GetListTerminalWithMerchantQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Terminal> terminals = await _terminalRepoitory.GetListAsync(
               index: request.PageRequest.PageIndex,
               size: request.PageRequest.PageSize,
               include:c=>c.Include(c=>c.Merchant),
               cancellationToken: cancellationToken);

            GetListResponse<GetListTerminalWithMerchantQueryResponse> response = _mapper.Map<GetListResponse<GetListTerminalWithMerchantQueryResponse>>(terminals);

            return response;
        }
    }
}
