namespace App1.Contracts;

using MediatR;

public record GetPersonRequest(int Id) : IRequest<MediatorResponse>;
public record GetPeopleRequest() : IRequest<MediatorResponse>;

public record GetAssignmentRequest(int Id) : IRequest<MediatorResponse>;
public record GetAssignmentsRequest() : IRequest<MediatorResponse>;

public record GetWorkloadRequest(int Id) : IRequest<MediatorResponse>;
public record GetWorkloadsRequest() : IRequest<MediatorResponse>;
