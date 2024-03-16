using frontorigins.Domain.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.database
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .OwnsOne(x => x.Address);

            modelBuilder.Entity<Department>()
                .OwnsOne(x => x.Location);

            modelBuilder.Entity<Client>()
                .OwnsOne(x => x.Address);

            modelBuilder.Entity<Company>()
                .OwnsOne(x => x.Location);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentPosition> DepartmentPositions { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Degree> Educations { get; set; }

        public DbSet<BusinessEquipement> BusinessEquipements { get; set; }


        public DbSet<Client> Clients { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<LendingEquipment> LendingEquipment { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Company> Organizations { get; set; }

        public DbSet<Timesheet> Timesheets { get; set; }

        public DbSet<WorkExperience> WorkExperiences { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
