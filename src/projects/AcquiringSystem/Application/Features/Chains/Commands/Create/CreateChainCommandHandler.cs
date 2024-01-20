using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using Domain.Entities;
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

        public async Task<CreateChainCommandResponse> Handle(CreateChainCommand request, CancellationToken cancellationToken)
        {
            await _chainBusinessRules.ChainCodeCanNotBeDuplicated(request.ChainCode);

            Chain chain = new(
                id: Guid.NewGuid().ToString(),
                chainCode:request.ChainCode,
                taxAdministration:request.TaxAdministration,
                chamberOfCommerce:request.ChamberOfCommerce,
                idType:request.IdType
                );

            await _chainRepository.AddAsync(chain);

            return new();
        }
    }
}
