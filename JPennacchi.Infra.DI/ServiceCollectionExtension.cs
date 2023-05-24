using FluentValidation;
using JPennacchi.Application.RequestReponse.Documento;
using JPennacchi.Application.Services.Implementations;
using JPennacchi.Application.Services.Interfaces;
using JPennacchi.Application.Validators;
using JPennacchi.Infra.Repository.Repositories;
using JPennacchi.Infra.Repository.Repositories.Implementations;
using JPennacchi.Infra.Repository.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JPennacchi.Infra.DI
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServiceCollection(this IServiceCollection services, IConfiguration configuration = null)
        {
            RegisterValidators(services);
            RegisterRepositories(services);
            RegisterServices(services);
            return services;
        }

        public static void RegisterValidators(IServiceCollection services)
        {
            services.AddScoped<IValidator<ObterDocumentoRequest>, ObterDocumentoValidator>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IDocumentoService, DocumentoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IDocumentoRepository, DocumentoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}