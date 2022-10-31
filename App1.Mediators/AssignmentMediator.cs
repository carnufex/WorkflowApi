namespace App1.Mediators;

using App1.Contracts;
using App1.Data.Abstract;

using AutoMapper;

using MediatR;

using Microsoft.Extensions.Logging;

using System.Threading;
using System.Threading.Tasks;

public class AssignmentMediator : IRequestHandler<GetAssignmentRequest, MediatorResponse>,
    IRequestHandler<GetAssignmentsRequest, MediatorResponse>,
    IRequestHandler<CreateAssignmentRequest, MediatorResponse>,
    IRequestHandler<UpdateAssignmentRequest, MediatorResponse>,
    IRequestHandler<DeleteAssignmentRequest, MediatorResponse>
{
    private readonly ILogger<AssignmentMediator> logger;
    private readonly IWorkloadService service;
    private readonly IMapper mapper;

    public AssignmentMediator(ILogger<AssignmentMediator> logger, IWorkloadService service, IMapper mapper)
    {
        this.logger = logger;
        this.service = service;
        this.mapper = mapper;
    }

    public Task<MediatorResponse> Handle(GetAssignmentRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(GetAssignmentsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(CreateAssignmentRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(UpdateAssignmentRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(DeleteAssignmentRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
