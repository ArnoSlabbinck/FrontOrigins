using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Education : BaseEntitiy
    {
        private string institutionName { get; set; }

        private string degreeLevel { get; set; }

        private string description { get; set; }

        private DateTime yearBeginning { get; set; }

        private DateTime yearCompletion { get; set; }

        private string major { get; set; }
        public Education() { }
    }
}
