using frontorigins.Domain.entities;


namespace frontorigins.Application.services
{
    public interface IEmployeeService
    {
        Task AddEmployee(Employee employee, CancellationToken cancellationToken);

        Task UpdateEmployee(Employee employee, int id, CancellationToken cancellationToken);

        Task DeleteEmployee(int id, CancellationToken cancellationToken);

        Task<Employee> GetEmployee(int id, CancellationToken cancellationToken);
    }
}
