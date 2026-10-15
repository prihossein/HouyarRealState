using System.Reflection;
using FluentValidation;
using HouyarRealState.Application.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace HouyarRealState.Application
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            ValidatorOptions.Global.LanguageManager = new FluentValidationCustomLanguageManager();

            services.AddAutoMapper(x => { }, Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
