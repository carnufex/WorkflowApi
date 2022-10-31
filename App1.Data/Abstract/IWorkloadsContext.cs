namespace App1.Data.Abstract;

using App1.Model;

using Microsoft.EntityFrameworkCore;

public interface IWorkloadsContext
{
    DbSet<Person> People { get; }
    DbSet<Assignment> Assignment { get; }
    DbSet<Workload> Workloads { get; }

    void EnsureExists();
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
