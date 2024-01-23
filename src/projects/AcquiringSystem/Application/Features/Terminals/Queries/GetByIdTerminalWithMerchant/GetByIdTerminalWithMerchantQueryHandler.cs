using Application.Features.Terminals.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Terminals.Queries.GetByIdTerminalWithMerchant
{
    public sealed class GetByIdTerminalWithMerchantQueryHandler : IRequestHandler<GetByIdTerminalWithMerchantQuery, GetByIdTerminalWithMerchantQueryResponse>
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly TerminalBusinessRules _terminalBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTerminalWithMerchantQueryHandler(ITerminalRepository terminalRepository, TerminalBusinessRules terminalBusinessRules, IMapper mapper)
        {
            _terminalRepository = terminalRepository;
            _terminalBusinessRules = terminalBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetByIdTerminalWithMerchantQueryResponse> Handle(GetByIdTerminalWithMerchantQuery request, CancellationToken cancellationToken)
        {
            await _terminalBusinessRules.GetTerminalExistsCheck(request.id);

            Terminal? terminal = await _terminalRepository.GetAsync(c => c.Id == request.id, include: c => c.Include(c => c.Merchant));

            var mappedTerminalListModel = _mapper.Map<GetByIdTerminalWithMerchantQueryResponse>(terminal);

            return mappedTerminalListModel;
        }
    }
}
