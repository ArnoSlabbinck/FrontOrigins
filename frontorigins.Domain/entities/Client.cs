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
    public class Client : BaseEntity
    {
        private string companyName;

        private string industry;

        private string email;
        
        private string clientName;

        private string clientPhone;

        private DateTime? lastContactDate;

        
        private Address address;

        public Client(long id) : base(id)
        {
        }


        public string CompanyName { get => companyName; set => companyName = value; }
        public string Industry { get => industry; set => industry = value; }
        public string Email { get => email; set => email = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientPhone { get => clientPhone; set => clientPhone = value; }
        public DateTime? LastContactDate { get => lastContactDate; set => lastContactDate = value; }
        public Address Address { get => address; set => address = value; }

        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   base.Equals(obj) &&
                   Id == client.Id &&
                   CreatedDate == client.CreatedDate &&
                   ModifiedDate == client.ModifiedDate &&
                   companyName == client.companyName &&
                   industry == client.industry &&
                   email == client.email &&
                   clientName == client.clientName &&
                   clientPhone == client.clientPhone &&
                   lastContactDate == client.lastContactDate &&
                   EqualityComparer<Address>.Default.Equals(Address, client.Address);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(CreatedDate);
            hash.Add(ModifiedDate);
            hash.Add(companyName);
            hash.Add(industry);
            hash.Add(email);
            hash.Add(clientName);
            hash.Add(clientPhone);
            hash.Add(lastContactDate);
            hash.Add(Address);
            return hash.ToHashCode();
        }
    }
}
