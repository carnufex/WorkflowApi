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

    public async Task<Person> GetPerson(int id)
    {
        Person? person = context.People.Where(x => x.Id == id).FirstOrDefault();

        if (person == null || person.Id == 0)
        {
            throw new PersonNotFoundException("No user with this id");
        }
        else
        {
            return await Task.Run(() => person); 
        }
    }

    public async Task<IEnumerable<Person>> GetPeople()
    {
        var people = context.People.Where(x => x.Id > 0);
        return await Task.Run(() => people);
    }

    public async Task<Person> AddPerson(Person person)
    {
        _ = context.People.Add(person);
        _ = await context.SaveChangesAsync();

        return person.Id == 0 ? throw new PersonNotSavedException("User not saved") : person;
    }

    public async Task<Person> UpdatePerson(Person person)
    {
        _ = context.People.Update(person);
        _ = await context.SaveChangesAsync();

        return person.Id == 0 ? throw new PersonNotFoundException("User not updated") : person;
    }

    public async Task<Person> DeletePerson(int id)
    {
        Person? person = context.People.Where(x => x.Id == id).FirstOrDefault();
        if (person != null)
        {
            _ = context.People.Remove(person);
            _ = await context.SaveChangesAsync();

            return person;
        }

        throw new PersonNotFoundException("There is no person with this id");
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


