using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Education : BaseEntity
    {
        private string institutionName;

        private string degreeLevel;

        private string description;

        private DateTime yearBeginning;

        private DateTime yearCompletion;

        private string major;

        public Education(long id) : base(id)
        {
        }

        public string InstitutionName { get => institutionName; set => institutionName = value; }
        public string DegreeLevel { get => degreeLevel; set => degreeLevel = value; }
        public string Description { get => description; set => description = value; }
        public DateTime YearBeginning { get => yearBeginning; set => yearBeginning = value; }
        public DateTime YearCompletion { get => yearCompletion; set => yearCompletion = value; }
        public string Major { get => major; set => major = value; }
    }
}
