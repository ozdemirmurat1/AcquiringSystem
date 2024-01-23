using Application.Features.Merchants.Rules;
using Application.Features.Terminals.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Terminals.Commands.Create
{
    public sealed class CreateTerminalCommandHandler : IRequestHandler<CreateTerminalCommand, CreateTerminalCommandResponse>
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly TerminalBusinessRules _terminalBusinessRules;
        private readonly IMapper _mapper;

        public CreateTerminalCommandHandler(ITerminalRepository terminalRepository, TerminalBusinessRules terminalBusinessRules, IMapper mapper)
        {
            _terminalRepository = terminalRepository;
            _terminalBusinessRules = terminalBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreateTerminalCommandResponse> Handle(CreateTerminalCommand request, CancellationToken cancellationToken)
        {
            await _terminalBusinessRules.CreateTerminalIdentificationCanNotBeDuplicated(request.TerminalIdentification);
            await _terminalBusinessRules.GetMerchantControlExist(request.MerchantId);

            Terminal terminal = _mapper.Map<Terminal>(request);

            terminal.Id = Guid.NewGuid().ToString();

            await _terminalRepository.AddAsync(terminal);

            return new();
        }
    }
}
