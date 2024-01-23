using Application.Features.Terminals.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Terminals.Commands.Update
{
    public sealed class UpdateTerminalCommandHandler : IRequestHandler<UpdateTerminalCommand, UpdateTerminalCommandResponse>
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly TerminalBusinessRules _terminalBusinessRules;
        private readonly IMapper _mapper;

        public UpdateTerminalCommandHandler(ITerminalRepository terminalRepository, TerminalBusinessRules terminalBusinessRules, IMapper mapper)
        {
            _terminalRepository = terminalRepository;
            _terminalBusinessRules = terminalBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdateTerminalCommandResponse> Handle(UpdateTerminalCommand request, CancellationToken cancellationToken)
        {
            await _terminalBusinessRules.GetTerminalExistsCheck(request!.id);
            await _terminalBusinessRules.GetMerchantControlExist(request.MerchantId);

            Terminal? terminal = await _terminalRepository.GetAsync(predicate: u => u.Id == request.id, cancellationToken: cancellationToken);


            await _terminalBusinessRules.UpdateTerminalIdentificationCanNotBeDuplicated(terminal!.TerminalIdentification, terminal.Id);

            terminal = _mapper.Map(request, terminal);

            await _terminalRepository.UpdateAsync(terminal);

            return new();
        }
    }
}
