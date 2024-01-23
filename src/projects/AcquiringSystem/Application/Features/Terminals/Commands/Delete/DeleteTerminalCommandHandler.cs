using Application.Features.Terminals.Rules;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Terminals.Commands.Delete
{
    public sealed class DeleteTerminalCommandHandler : IRequestHandler<DeleteTerminalCommand, DeleteTerminalCommandResponse>
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly TerminalBusinessRules _terminalBusinessRules;

        public DeleteTerminalCommandHandler(ITerminalRepository terminalRepository, TerminalBusinessRules terminalBusinessRules)
        {
            _terminalRepository = terminalRepository;
            _terminalBusinessRules = terminalBusinessRules;
        }

        public async Task<DeleteTerminalCommandResponse> Handle(DeleteTerminalCommand request, CancellationToken cancellationToken)
        {
            await _terminalBusinessRules.GetTerminalExistsCheck(request.id);

            Terminal? terminal = await _terminalRepository.GetAsync(predicate: uoc => uoc.Id == request.id,
            cancellationToken: cancellationToken);

            await _terminalRepository.DeleteAsync(terminal!);

            return new();
        }
    }
}
