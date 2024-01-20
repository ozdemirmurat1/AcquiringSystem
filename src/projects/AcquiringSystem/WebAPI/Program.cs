
using Application;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
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

            builder.Services.AddControllers();
            builder.Services.AddApplicationServices();

            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddHttpContextAccessor();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(
                opt =>
                    opt.AddDefaultPolicy(p =>
                    {
                        p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    })
            );

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
                //opt.OperationFilter<BearerSecurityRequirementOperationFilter>();
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(opt =>
                {
                    opt.DocExpansion(DocExpansion.None);
                });
                app.ConfigureCustomExceptionMiddleware();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
