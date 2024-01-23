﻿using Application.Features.Terminals.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Terminals.Queries.GetById
{
    public sealed class GetByIdTerminalQueryHandler : IRequestHandler<GetByIdTerminalQuery, GetByIdTerminalQueryResponse>
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly TerminalBusinessRules _terminalBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTerminalQueryHandler(ITerminalRepository terminalRepository, TerminalBusinessRules terminalBusinessRules, IMapper mapper)
        {
            _terminalRepository = terminalRepository;
            _terminalBusinessRules = terminalBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetByIdTerminalQueryResponse> Handle(GetByIdTerminalQuery request, CancellationToken cancellationToken)
        {
            await _terminalBusinessRules.GetTerminalExistsCheck(request.id);

            Terminal? terminal = await _terminalRepository.GetAsync(
                c => c.Id == request.id,
                cancellationToken: cancellationToken);

            var mappedTerminalListModel = _mapper.Map<GetByIdTerminalQueryResponse>(terminal);

            return mappedTerminalListModel;
        }
    }
}
