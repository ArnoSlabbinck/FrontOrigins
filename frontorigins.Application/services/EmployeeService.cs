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

        public async Task AddEmployee(Employee employee, CancellationToken cancellationToken)
        {
            await EmployeeRepository.Add(employee, cancellationToken);
           
            
        }

        public async Task DeleteEmployee(int id, CancellationToken cancellationToken)
        {
            await EmployeeRepository.Delete(id, cancellationToken);
        }

        public async Task<Employee> GetEmployee(int id, CancellationToken cancellationToken)
        {
            return await EmployeeRepository.GetById(id, cancellationToken);
        }

        public async Task UpdateEmployee(Employee employee, int id, CancellationToken cancellationToken)
        {
            await EmployeeRepository.Update(employee, id, cancellationToken);
        }
    }
}
