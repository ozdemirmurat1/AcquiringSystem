using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using MediatR;

namespace Application.Features.Chains.Commands.Create
{
    public sealed class CreateChainCommandHandler : IRequestHandler<CreateChainCommand, CreateChainCommandResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;

        public CreateChainCommandHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
        }

        public Task<CreateChainCommandResponse> Handle(CreateChainCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
