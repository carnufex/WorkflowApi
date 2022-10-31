namespace App1.Contracts;

using MediatR;

public record CreatePersonRequest(string FirstName, string LastName) : IRequest<MediatorResponse>;
public record UpdatePersonRequest(int Id, string FirstName, string LastName) : IRequest<MediatorResponse>;
public record DeletePersonRequest(int Id) : IRequest<MediatorResponse>;

public record CreateAssignmentRequest(string Description) : IRequest<MediatorResponse>;
public record UpdateAssignmentRequest(int Id, string Description) : IRequest<MediatorResponse>;
public record DeleteAssignmentRequest(int Id) : IRequest<MediatorResponse>;

public record CreateWorkloadRequest(DateTimeOffset Start, int PersonId, int AssignmentId) : IRequest<MediatorResponse>;
public record UpdateWorkloadRequest(int Id, DateTimeOffset Start, DateTimeOffset? Stop, int PersonId, int AssignmentId) : IRequest<MediatorResponse>;
public record DeleteWorkloadRequest(int Id) : IRequest<MediatorResponse>;
