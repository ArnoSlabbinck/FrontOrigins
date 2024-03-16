using frontorigins.Domain.entities;
using frontorigins.Infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository EmployeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        public void AddEmployee(Employee employee, CancellationToken cancellationToken)
        {
               
        }

        public void DeleteEmployee(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
