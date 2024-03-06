using frontorigins.Domain.aggregates;
using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Organization : BaseEntity
    {
        private string description;

        private string name;

        private string phone;

        private string taxNumber;

        private Address location;

        private ICollection<Departement> departments;

        public Organization(long id) : base(id)
        {
        }

        public Organization(long id, string description, string name, string phone, string taxNumber, Address location, ICollection<Departement> departements) : base(id)
        {
            this.description = description;
            this.name = name;
            this.phone = phone;
            this.taxNumber = taxNumber;
            this.location = location;
            this.departments = departements;
        }

        public string Description { get => description; set => description = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string TaxNumber { get => taxNumber; set => taxNumber = value; }
        public Address Location { get => location; set => location = value; }
        public ICollection<Departement> Departments { get => departments; set => departments = value; }
    }
}
