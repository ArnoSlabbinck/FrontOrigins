using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Client : BaseEntitiy
    {
        private string companyName { get; set; }

        private string industry { get; set; }

        private string email { get; set; }

        private string clientName { get; set; }

        private string clientPhone { get; set; }

        private DateTime? lastContactDate { get; set; }

        private Location Address { get; set; }


        public Client() { }
    }
}
