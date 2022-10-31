namespace App1.Model;

public class Workload
{
    public int Id { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? Stop { get; set; }

    //Foreign keys
    public int PersonId { get; set; }
    public int AssignmentId { get; set; }

    //Browsing properties
    public Person Person { get; set; }
    public Assignment Assignment { get; set; }
}
