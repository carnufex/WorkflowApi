namespace App1.Contracts;
public record PersonResponse(int Id, string FirstName, string LastName);

public record AssignmentResponse(int Id, string Description);

public record WorkloadResponse(int Id, DateTimeOffset Start, DateTimeOffset Stop, PersonResponse Person, AssignmentResponse Assignment);
