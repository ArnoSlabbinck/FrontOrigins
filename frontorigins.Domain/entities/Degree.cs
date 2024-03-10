using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Degree : BaseEntity
    {
        public Degree(long id) : base(id)
        {
        }

        
        private string institutionName;

        
        private CollegeDegree degreeLevel;

        private string? description;

        private DateTime yearBeginning;

        private DateTime yearCompletion;

       
        private string major;
       
        public string InstitutionName { get => institutionName; set => institutionName = value; }
        public CollegeDegree DegreeLevel { get => degreeLevel; set => degreeLevel = value; }
        public string Description { get => description; set => description = value; }
        public DateTime YearBeginning { get => yearBeginning; set => yearBeginning = value; }
        public DateTime YearCompletion { get => yearCompletion; set => yearCompletion = value; }
        public string Major { get => major; set => major = value; }

        public override bool Equals(object? obj)
        {
            return obj is Degree education &&
                   base.Equals(obj) &&
                   Id == education.Id &&
                   CreatedDate == education.CreatedDate &&
                   ModifiedDate == education.ModifiedDate &&
                   institutionName == education.institutionName &&
                   degreeLevel == education.degreeLevel &&
                   description == education.description &&
                   yearBeginning == education.yearBeginning &&
                   yearCompletion == education.yearCompletion &&
                   major == education.major;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(CreatedDate);
            hash.Add(ModifiedDate);
            hash.Add(institutionName);
            hash.Add(degreeLevel);
            hash.Add(description);
            hash.Add(yearBeginning);
            hash.Add(yearCompletion);
            hash.Add(major);
            return hash.ToHashCode();
        }
    }
}
