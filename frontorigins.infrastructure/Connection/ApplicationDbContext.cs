using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontorigins.Domain.aggregates;
using frontorigins.Domain.entities;
using Microsoft.EntityFrameworkCore;

namespace frontorigins.Infrastructure.Connection
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .OwnsOne(x => x.Address);

            modelBuilder.Entity<Departement>()
                .OwnsOne(x => x.Location);

            modelBuilder.Entity<Client>()
                .OwnsOne(x => x.Address);

            modelBuilder.Entity<Organization>()
                .OwnsOne(x => x.Location);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Departement> Departments { get; set; }

        public DbSet<DepartmentPosition> DepartmentPositions { get; set; }  

        public DbSet<Position> Positions { get; set; }  

        public DbSet<Education> Educations { get; set; }

        public DbSet<BusinessEquipment> BusinessEquipements { get; set; }


        public DbSet<Client> Clients { get; set; }  

        public DbSet<Language> Languages { get; set; }  

        public DbSet<LendingEquipment> LendingEquipment { get; set; }   

        public DbSet<Skill> Skills { get; set; }    

        public DbSet<Organization> Organizations { get; set; }  

        public DbSet<Timesheet> Timesheets { get; set; }    

        public DbSet<WorkExperience> WorkExperiences { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
