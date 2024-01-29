using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Features.Chains.Commands.Create
{
    // BURADA LOGLAMA VAR DETAYLARINA BAKARSIN
    public sealed class CreateChainCommandHandler : IRequestHandler<CreateChainCommand, CreateChainCommandResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;
        private readonly LoggerServiceBase _loggerServiceBase;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CreateChainCommandHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules, LoggerServiceBase loggerServiceBase, IHttpContextAccessor httpContextAccessor)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
            _loggerServiceBase = loggerServiceBase;
            _httpContextAccessor = httpContextAccessor;
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

            List<LogParameter> logParameters =
               new()
               {
                new LogParameter {Type=request.GetType().Name, Value=request}
               };
            LogDetail logDetail =
                new()
                {
                    MethodName = "CreateChainCommandHandler",
                    Parameters = logParameters,
                    User = _httpContextAccessor.HttpContext.User.Identity?.Name ?? "?"
                };

            _loggerServiceBase.Info(JsonSerializer.Serialize(logDetail));

            await _chainRepository.AddAsync(chain);

            return new();
        }
    }
}
