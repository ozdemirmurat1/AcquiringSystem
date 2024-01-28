
using Application;
using Core.Security;
using Core.Security.Encryption;
using Core.Security.JWT;
using Core.WebAPI.Extensions.Swagger;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Persistence;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddControllers();
            builder.Services.AddApplicationServices();
            builder.Services.AddSecurityServices();
            builder.Services.AddPersistenceServices(builder.Configuration);
            

            const string tokenOptionsConfigurationSection = "TokenOptions";
            TokenOptions tokenOptions =
                builder.Configuration.GetSection(tokenOptionsConfigurationSection).Get<TokenOptions>()
                ?? throw new InvalidOperationException($"\"{tokenOptionsConfigurationSection}\" section cannot found in configuration.");
            builder.Services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer("Admin",options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
                policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials()
              ));

            builder.Services.AddSwaggerGen(opt =>
            {
                opt.AddSecurityDefinition(
                    name: "Bearer",
                    securityScheme: new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        Type = SecuritySchemeType.Http,
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        In = ParameterLocation.Header,
                        Description =
                            "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer YOUR_TOKEN\". \r\n\r\n"
                            + "`Enter your token in the text input below.`"
                    }
                );
                opt.OperationFilter<BearerSecurityRequirementOperationFilter>();
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(opt =>
                {
                    opt.DocExpansion(DocExpansion.None);
                });
                //app.ConfigureCustomExceptionMiddleware();
            }

            app.UseCors();

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            const string webApiConfigurationSection = "WebAPIConfiguration";
            WebApiConfiguration webApiConfiguration =
                app.Configuration.GetSection(webApiConfigurationSection).Get<WebApiConfiguration>()
                ?? throw new InvalidOperationException($"\"{webApiConfigurationSection}\" section cannot found in configuration.");
            app.UseCors(opt => opt.WithOrigins(webApiConfiguration.AllowedOrigins).AllowAnyHeader().AllowAnyMethod().AllowCredentials());

            app.Run();
        }
    }
}
