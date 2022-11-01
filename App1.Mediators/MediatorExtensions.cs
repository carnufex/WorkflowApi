namespace App1.Mediators;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

public static class MediatorExtensions
{
    public static IServiceCollection AddMediatorStuff(this IServiceCollection services)
    {
        _ = services.AddAutoMapper(typeof(ModelTranslator));
        _ = services.AddMediatR(typeof(PersonMediator).Assembly);
        return services;
    }
}
