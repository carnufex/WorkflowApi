namespace App1.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class WorkloadContextDesignTimeFactory : IDesignTimeDbContextFactory<WorkloadContext>
{
    public WorkloadContext CreateDbContext(string[] args)
    {
        IConfiguration? configuration = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddUserSecrets("ConnectionStrings")
            //The common UserSecrets for my user!
            //Points to C:\Users\%username%\AppData\Roaming\Microsoft\UserSecrets\ConnectionStrings\secrets.json
            .Build();
        DbContextOptionsBuilder<WorkloadContext> optionsBuilder = new();
        _ = optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyWorkloads"));

        return new WorkloadContext(optionsBuilder.Options);
    }
}
