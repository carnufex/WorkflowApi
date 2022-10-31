namespace App1.Model;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    //Browsing properties
    public ICollection<Workload> Workloads { get; set; } = new HashSet<Workload>();
}
