﻿using frontorigins.Domain.aggregates;
using frontorigins.Domain.common;
using System.ComponentModel.DataAnnotations;

namespace frontorigins.Domain.entities
{
    public class Department : BaseEntity
    {
        
        private string sector;

        private string mail;

        private string phone;

        private Address location;

        public Department(long id) : base(id)
        {
        }

      
        public string Sector { get => sector; set => sector = value; }

        public string Mail { get => mail; set => mail = value; }
        
        public string Phone { get => phone; set => phone = value; }
        public virtual Address Location { get => location; set => location = value; }

        public override bool Equals(object? obj)
        {
            return obj is Department departement &&
                   base.Equals(obj) &&
                   Id == departement.Id &&
                   CreatedDate == departement.CreatedDate &&
                   ModifiedDate == departement.ModifiedDate &&
                   sector == departement.sector &&
                   EqualityComparer<Address>.Default.Equals(location, departement.location);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, CreatedDate, ModifiedDate, sector, location);
        }
    }
}