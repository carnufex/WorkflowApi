namespace App1.Mediators;

using App1.Contracts;
using App1.Model;

using AutoMapper;

public class ModelTranslator : Profile
{
    public ModelTranslator()
    {
        _ = CreateMap<CreatePersonRequest, Person>();
        _ = CreateMap<UpdatePersonRequest, Person>();
        _ = CreateMap<Person, PersonResponse>()
            .ForCtorParam("Id", b => b.MapFrom(p => p.Id))
            .ForCtorParam("FirstName", b => b.MapFrom(p => p.FirstName))
            .ForCtorParam("LastName", b => b.MapFrom(p => p.LastName));

        _ = CreateMap<CreateAssignmentRequest, Assignment>();
        _ = CreateMap<UpdateAssignmentRequest, Assignment>();
        _ = CreateMap<Assignment, AssignmentResponse>()
            .ForCtorParam("Id", b => b.MapFrom(p => p.Id))
            .ForCtorParam("Description", b => b.MapFrom(p => p.Description));

        _ = CreateMap<CreateWorkloadRequest, Workload>();
        _ = CreateMap<UpdateWorkloadRequest, Workload>();
        //_ = CreateMap<Workload, WorkloadResponse>()
        //    .ForCtorParam("Id", b => b.MapFrom(p => p.Id))
        //    .ForCtorParam("Start", b => b.MapFrom(p => p.Start))
        //    .ForCtorParam("Stop", b => b.MapFrom(p => p.Stop))
        //    .ForCtorParam("PersonId", b => b.MapFrom(p => p.PersonId))
        //    .ForCtorParam("AssignmentId,", b => b.MapFrom(p => p.AssignmentId));
    }
}
