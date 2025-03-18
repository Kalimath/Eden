using System.Reflection;
using FluentValidation;
using MbDevelopment.Eden.BotanicalAPI.Shared.Base;
using MediatR;

namespace MbDevelopment.Eden.BotanicalAPI;

public static class RegisterBotanicalApi
{
    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(Program).Assembly);
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        return services;
    }
    
    public static IServiceCollection AddCqrs(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}