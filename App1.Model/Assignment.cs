namespace App1.Model;

public class Assignment
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;

    //Browsing properties
    public ICollection<Workload> Workloads { get; set; } = new HashSet<Workload>();
}
