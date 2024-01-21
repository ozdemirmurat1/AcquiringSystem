using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Domain.Entities;
using MediatR;

namespace Application.Features.Chains.Commands.Update
{
    public sealed class UpdateChainCommanHandler : IRequestHandler<UpdateChainCommand, UpdateChainCommandResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;
        private readonly LoggerServiceBase _loggerServiceBase;

        public UpdateChainCommanHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules, LoggerServiceBase loggerServiceBase)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
            _loggerServiceBase = loggerServiceBase;
        }

        public async Task<UpdateChainCommandResponse> Handle(UpdateChainCommand request, CancellationToken cancellationToken)
        {

            await _chainBusinessRules.GetChainExistsCheck(request!.id);

            Chain? chain = await _chainRepository.GetAsync(predicate: u => u.Id == request.id, cancellationToken: cancellationToken);

            await _chainBusinessRules.UpdateChainCodeCanNotBeDuplicated(chain!.ChainCode, chain.Id);

            chain.ChainCode=request.ChainCode;
            chain.TaxAdministration=request.TaxAdministration;
            chain.ChamberOfCommerce=request.ChamberOfCommerce;
            chain.IdType=request.IdType;

            await _chainRepository.UpdateAsync(chain);
            _loggerServiceBase.Info("İŞ YERİ BAŞARIYL GÜNCELLENDİ");

            return new();
        }

    }
}
