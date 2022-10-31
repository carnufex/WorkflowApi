namespace App1.Data;

using App1.Data.Abstract;
using App1.Model;

using Microsoft.EntityFrameworkCore;

public class WorkloadContext : DbContext, IWorkloadsContext
{
    public DbSet<Person> People => Set<Person>();

    public DbSet<Assignment> Assignment => Set<Assignment>();

    public DbSet<Workload> Workloads => Set<Workload>();

    public WorkloadContext(DbContextOptions options)
        : base(options) { }

    public void EnsureExists()
    {
        if (Database.GetPendingMigrations().Any())
        {
            Database.Migrate();
        }
    }
}
