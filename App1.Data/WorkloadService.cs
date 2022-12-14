namespace App1.Data;

using App1.Data.Abstract;
using App1.Data.Exceptions;
using App1.Model;

public class WorkloadService : IWorkloadService
{
    private readonly IWorkloadsContext context;

    public WorkloadService(IWorkloadsContext context)
    {
        this.context = context;
    }

    public Task<Person> GetPerson(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Person>> GetPeople()
    {
        throw new NotImplementedException();
    }

    public async Task<Person> AddPerson(Person person)
    {
        _ = context.People.Add(person);
        _ = await context.SaveChangesAsync();

        return person.Id == 0 ? throw new PersonNotSavedException("User not saved") : person;
    }

    public Task<Person> UpdatePerson(Person person)
    {
        throw new PersonNotFoundException("Person not found");
    }

    public Task<Person> DeletePerson(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Assignment> GetAssignment(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Assignment>> GetAssignments()
    {
        throw new NotImplementedException();
    }

    public Task<Assignment> AddAssignment(Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task<Assignment> UpdateAssignment(Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task<Assignment> DeleteAssignment(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Workload> GetWorkload(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Workload>> GetWorkloads()
    {
        throw new NotImplementedException();
    }

    public Task<Workload> AddWorkload(Workload workload)
    {
        throw new NotImplementedException();
    }

    public Task<Workload> UpdateWorkload(Workload workload)
    {
        throw new NotImplementedException();
    }

    public Task<Workload> DeleteWorkload(int id)
    {
        throw new NotImplementedException();
    }
}


