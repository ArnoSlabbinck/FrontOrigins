using frontorigins.Domain.entities;
using frontorigins.Infrastructure.database;
using frontorigins.Infrastructure.unitofwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext, IUnitOfWork unitOfWork) : base(dbContext, unitOfWork)
        {
        }
    }
}
