using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Domain.Entities;
using MediatR;

namespace Application.Features.Chains.Commands.Create
{
    // BURADA LOGLAMA VAR DETAYLARINA BAKARSIN
    public sealed class CreateChainCommandHandler : IRequestHandler<CreateChainCommand, CreateChainCommandResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;
        private readonly LoggerServiceBase _loggerServiceBase;

        public CreateChainCommandHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules, LoggerServiceBase loggerServiceBase)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
            _loggerServiceBase = loggerServiceBase;
        }

        public async Task<CreateChainCommandResponse> Handle(CreateChainCommand request, CancellationToken cancellationToken)
        {
            await _chainBusinessRules.CreateChainCodeCanNotBeDuplicated(request.ChainCode);

            Chain chain = new(
                id: Guid.NewGuid().ToString(),
                chainCode:request.ChainCode,
                taxAdministration:request.TaxAdministration,
                chamberOfCommerce:request.ChamberOfCommerce,
                idType:request.IdType
            );

            _loggerServiceBase.Info("İŞ YERİ BAŞARIYLA OLUŞTURULDU!");
            await _chainRepository.AddAsync(chain);

            return new();
        }
    }
}
