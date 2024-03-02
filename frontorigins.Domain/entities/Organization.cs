using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Organization : BaseEntitiy
    {
        private string description { get; set; }

        private string name { get; set; }

        private string phone { get; set; }

        private string taxNumber { get; set; }

        private Location location { get; set; }

        ICollection<Departement> departements { get; set; }




        public Organization() { }
    }
}
