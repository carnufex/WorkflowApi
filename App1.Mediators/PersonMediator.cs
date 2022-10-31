namespace App1.Mediators;

using App1.Contracts;
using App1.Data.Abstract;
using App1.Data.Exceptions;
using App1.Model;

using AutoMapper;

using MediatR;

using Microsoft.Extensions.Logging;

using System;
using System.Threading;
using System.Threading.Tasks;

public class PersonMediator : IRequestHandler<GetPeopleRequest, MediatorResponse>,
    IRequestHandler<GetPersonRequest, MediatorResponse>,
    IRequestHandler<CreatePersonRequest, MediatorResponse>,
    IRequestHandler<UpdatePersonRequest, MediatorResponse>,
    IRequestHandler<DeletePersonRequest, MediatorResponse>
{
    private readonly ILogger<PersonMediator> logger;
    private readonly IWorkloadService service;
    private readonly IMapper mapper;

    public PersonMediator(ILogger<PersonMediator> logger, IWorkloadService service, IMapper mapper)
    {
        this.logger = logger;
        this.service = service;
        this.mapper = mapper;
    }

    public Task<MediatorResponse> Handle(GetPersonRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<MediatorResponse> Handle(GetPeopleRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<MediatorResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        try
        {
            Person person = await service.AddPerson(mapper.Map<Person>(request));

            return new MediatorResponse { Status = 200, Result = mapper.Map<PersonResponse>(person) };
        }
        catch (PersonNotSavedException ex)
        {
            return new MediatorResponse { Status = 400, Result = new ErrorDetails { Message = ex.Message } };
        }
    }

    public async Task<MediatorResponse> Handle(UpdatePersonRequest request, CancellationToken cancellationToken)
    {
        try
        {
            Person person = await service.UpdatePerson(mapper.Map<Person>(request));

            return new MediatorResponse { Status = 200, Result = mapper.Map<PersonResponse>(person) };
        }
        catch (PersonNotFoundException ex)
        {
            return new MediatorResponse { Status = 404, Result = new ErrorDetails { Message = ex.Message } };
        }
    }

    public Task<MediatorResponse> Handle(DeletePersonRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
