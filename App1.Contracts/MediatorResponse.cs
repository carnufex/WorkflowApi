namespace App1.Contracts;

public class MediatorResponse
{
    public int Status { get; set; }
    public object Result { get; set; } = new object();
}