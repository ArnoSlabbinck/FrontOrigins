using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.services
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee, CancellationToken cancellationToken);

        void UpdateEmployee(Employee employee, CancellationToken cancellationToken);

        void DeleteEmployee(int id, CancellationToken cancellationToken);

        Task<Employee> GetEmployee(int id, CancellationToken cancellationToken);
    }
}
