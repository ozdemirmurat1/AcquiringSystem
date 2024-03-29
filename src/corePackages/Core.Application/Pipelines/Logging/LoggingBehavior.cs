﻿using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Text.Json;


namespace Core.Application.Pipelines.Logging
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>, ILoggableRequest
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly LoggerServiceBase _loggerServiceBase;

        public LoggingBehavior(IHttpContextAccessor httpContextAccessor, LoggerServiceBase loggerServiceBase)
        {
            _httpContextAccessor = httpContextAccessor;
            _loggerServiceBase = loggerServiceBase;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            List<LogParameter> logParameters =
                new()
                {
                new LogParameter {Type=request.GetType().Name, Value=request}
                };

            // metot name de query ve command ların ismi api ile aynı olabilir.Böylece çözüm sağlayabilirsin.

            LogDetail logDetail =
                new()
                {
                    // METHOD İSMİ TAM GELMİYOR BAK!!!
                    MethodName = next.Method.Name,
                    Parameters = logParameters,
                    User = _httpContextAccessor.HttpContext.User.Identity?.Name ?? "?"
                };

            _loggerServiceBase.Info(JsonSerializer.Serialize(logDetail));
            return await next();
        }
    }
}
