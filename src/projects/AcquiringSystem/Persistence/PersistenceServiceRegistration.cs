using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AcquiringSystemConnectionString")));

            services.AddScoped<IChainRepository, ChainRepository>();
            services.AddScoped<IMerchantRepository, MerchantRepository>();
            services.AddScoped<ITerminalRepository, TerminalRepository>();

            _ = services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
            _ = services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
            _ = services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
            _ = services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            _ = services.AddScoped<IUserRepository, UserRepository>();
            _ = services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();

            return services;
        }
    }
}
