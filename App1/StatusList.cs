namespace App1;

using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;

public class StatusList
{
    public List<string> CurrentStatus { get; set; } = new();
}

public static class ControllerExtensions
{
    public static IServiceCollection AddStatusList(this IServiceCollection services)
    {
        _ = services.AddSingleton<StatusList>();

        return services;
    }
}
