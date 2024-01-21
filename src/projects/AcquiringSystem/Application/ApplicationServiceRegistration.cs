using Microsoft.Extensions.DependencyInjection;
using Core.Application.Pipelines.Logging;
using System.Reflection;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Logging.Serilog.Logger;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Core.Application.Pipelines.Validation;
using FluentValidation;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                configuration.AddOpenBehavior(typeof(LoggingBehavior<,>));
                configuration.AddOpenBehavior(typeof(RequestValidationBehavior<,>));
            });

            services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddSingleton<LoggerServiceBase, FileLogger>();
            services.AddSingleton<LoggerServiceBase, MsSqlLogger>();

            return services;
        }

        public static IServiceCollection AddSubClassesOfType(this IServiceCollection services, Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (Type? item in types)
            {
                if (addWithLifeCycle == null)
                    services.AddScoped(item);
                else
                    addWithLifeCycle(services, type);
            }

            return services;
        }
    }
}
