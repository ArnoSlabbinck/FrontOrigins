using frontorigins.Domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.Seed
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(OnSeedingEmployees());
        }

        private List<Employee> OnSeedingEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee(1)
                {
                    FirstName = "Arno",
                    LastName = "Slabbinck",
                    MobilePhone = "+32472741605",
                    Email = "Arno.Slabbinck@gmail.com",
                    Gender = Domain.common.Gender.Male,
                    Nationality = "Belg", 
                    BankAccountNumber = "5398 5312 4598 3723", 
                    BirthDate = DateTime.Now, 
                    BirthPlace = "Jette"
                }
            };

            return employees;
        }

     
    }
}
