using FluentValidation;
using System.Reflection;
using BurguerMania.Application.Validators;
using Microsoft.Extensions.DependencyInjection;
using BurguerMania.Domain.Interfaces;

namespace BurguerMania.Application
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddValidatorsFromAssemblyContaining<UserValidator>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}