using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Domain.Entities;
using MediatR;

namespace Application.Features.Chains.Commands.Delete
{
    // LOGLAR GELİŞTİRLMELİ ÖRNEK OLMASI AÇISINDAN SADE EKLEDİM.
    public sealed class DeleteChainCommandHandler : IRequestHandler<DeleteChainCommand, DeleteChainCommandResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;
        private readonly LoggerServiceBase _loggerServiceBase;

        public DeleteChainCommandHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules, LoggerServiceBase loggerServiceBase)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
            _loggerServiceBase = loggerServiceBase;
        }

        public async Task<DeleteChainCommandResponse> Handle(DeleteChainCommand request, CancellationToken cancellationToken)
        {
            await _chainBusinessRules.GetChainExistsCheck(request.id);

            Chain? chain = await _chainRepository.GetAsync(predicate: uoc => uoc.Id == request.id,
                    cancellationToken: cancellationToken);

            await _chainRepository.DeleteAsync(chain!);

            _loggerServiceBase.Info("İş Yeri Başarıyla Silindi!");

            return new();


        }
    }
}
