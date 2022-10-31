namespace App1.Data.Abstract;

using App1.Model;

public interface IWorkloadService
{
    Task<Person> GetPerson(int id);
    Task<IEnumerable<Person>> GetPeople();
    Task<Person> AddPerson(Person person);
    Task<Person> UpdatePerson(Person person);
    Task<Person> DeletePerson(int id);

    Task<Assignment> GetAssignment(int id);
    Task<IEnumerable<Assignment>> GetAssignments();
    Task<Assignment> AddAssignment(Assignment assignment);
    Task<Assignment> UpdateAssignment(Assignment assignment);
    Task<Assignment> DeleteAssignment(int id);

    Task<Workload> GetWorkload(int id);
    Task<IEnumerable<Workload>> GetWorkloads();
    Task<Workload> AddWorkload(Workload workload);
    Task<Workload> UpdateWorkload(Workload workload);
    Task<Workload> DeleteWorkload(int id);
}


