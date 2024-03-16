using frontorigins.Domain.aggregates;
using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Company : BaseEntity
    {
       
        private string name;

        private string description;
        
        private string taxNumber;

       
        private Address location;

        private ICollection<Department> departments;

        public Company(long id) : base(id)
        {
        }

     
        public string Description { get => description; set => description = value; }
        public string Name { get => name; set => name = value; }
        public string TaxNumber { get => taxNumber; set => taxNumber = value; }
        public virtual Address Location { get => location; set => location = value; }
        public virtual ICollection<Department> Departments { get => departments; set => departments = value; }
    }
}
