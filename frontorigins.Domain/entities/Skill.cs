using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Skill : BaseEntitiy
    {
        private string name { get; set; }

        private string category { get; set; }

        private string notes { get; set; }

        private string level { get; set; }


        public Skill() { }
    }
}
