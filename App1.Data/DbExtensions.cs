namespace App1.Data;

using App1.Data.Abstract;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DbExtensions
{
    public static IServiceCollection AddDbStuff(this IServiceCollection services, Func<IConfiguration, string> config)
    {
        IServiceProvider serviceProvider = services.BuildServiceProvider();
        IConfiguration configuration = serviceProvider.GetRequiredService<IConfiguration>();
        string connectionString = config.Invoke(configuration);

        _ = services.AddDbContext<IWorkloadsContext, WorkloadContext>(optionsBuilder => optionsBuilder.UseSqlServer(connectionString));
        _ = services.AddTransient<IWorkloadService, WorkloadService>();

        return services;
    }
}
