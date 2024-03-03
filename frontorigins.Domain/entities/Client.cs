using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
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

        private Location Address;

        public Client(long id) : base(id)
        {
        }

        public string CompanyName { get => companyName; set => companyName = value; }
        public string Industry { get => industry; set => industry = value; }
        public string Email { get => email; set => email = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientPhone { get => clientPhone; set => clientPhone = value; }
        public DateTime? LastContactDate { get => lastContactDate; set => lastContactDate = value; }
        public Location Address1 { get => Address; set => Address = value; }
    }
}
