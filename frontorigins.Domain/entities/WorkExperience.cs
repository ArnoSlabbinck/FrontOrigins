using frontorigins.Domain.common;
using System.ComponentModel.DataAnnotations;

namespace frontorigins.Domain.entities
{
    public class WorkExperience : BaseEntity
    {
        private string title;

        private string? description;

      
        private string companyName;

        private DateTime employementStartDate;

        private DateTime employmentEndDate;

        public WorkExperience(long id) : base(id)
        {
        }

       

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public DateTime EmployementStartDate { get => employementStartDate; set => employementStartDate = value; }
        public DateTime EmploymentEndDate { get => employmentEndDate; set => employmentEndDate = value; }

        public override bool Equals(object? obj)
        {
            return obj is WorkExperience experience &&
                   base.Equals(obj) &&
                   Id == experience.Id &&
                   CreatedDate == experience.CreatedDate &&
                   ModifiedDate == experience.ModifiedDate &&
                   title == experience.title &&
                   description == experience.description &&
                   companyName == experience.companyName &&
                   employementStartDate == experience.employementStartDate &&
                   employmentEndDate == experience.employmentEndDate;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(CreatedDate);
            hash.Add(ModifiedDate);
            hash.Add(title);
            hash.Add(description);
            hash.Add(companyName);
            hash.Add(employementStartDate);
            hash.Add(employmentEndDate);
            return hash.ToHashCode();
        }
    }
}