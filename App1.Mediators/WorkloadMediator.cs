namespace App1.Mediators;

using App1.Contracts;
using App1.Data.Abstract;

using AutoMapper;

using MediatR;

using Microsoft.Extensions.Logging;

using System.Threading;
using System.Threading.Tasks;

public class WorkloadMediator : IRequestHandler<GetWorkloadRequest, MediatorResponse>,
    IRequestHandler<GetWorkloadsRequest, MediatorResponse>,
    IRequestHandler<CreateWorkloadRequest, MediatorResponse>,
    IRequestHandler<UpdateWorkloadRequest, MediatorResponse>,
    IRequestHandler<DeleteWorkloadRequest, MediatorResponse>
{
    private readonly ILogger<WorkloadMediator> logger;
    private readonly IWorkloadService service;
    private readonly IMapper mapper;

    public WorkloadMediator(ILogger<WorkloadMediator> logger, IWorkloadService service, IMapper mapper)
    {
        this.logger = logger;
        this.service = service;
        this.mapper = mapper;
    }

    public Task<MediatorResponse> Handle(GetWorkloadRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(GetWorkloadsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(CreateWorkloadRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(UpdateWorkloadRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(DeleteWorkloadRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}