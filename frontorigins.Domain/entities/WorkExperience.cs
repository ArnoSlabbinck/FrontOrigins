using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class WorkExperience : BaseEntity
    {
        private string title;

        private string description;

        private string supervisorName;

        private string supervisorContact;

        private DateTime employementStartDate;
        private DateTime employmentEndDate;

        public WorkExperience(long id) : base(id)
        {
        }

        public WorkExperience(long id, string title, string description, string supervisorName, string supervisorContact, DateTime employementStartDate, DateTime employmentEndDate) : base(id)
        {
            this.title = title;
            this.description = description;
            this.supervisorName = supervisorName;
            this.supervisorContact = supervisorContact;
            this.employementStartDate = employementStartDate;
            this.employmentEndDate = employmentEndDate;
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string SupervisorName { get => supervisorName; set => supervisorName = value; }
        public string SupervisorContact { get => supervisorContact; set => supervisorContact = value; }
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
                   supervisorName == experience.supervisorName &&
                   supervisorContact == experience.supervisorContact &&
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
            hash.Add(supervisorName);
            hash.Add(supervisorContact);
            hash.Add(employementStartDate);
            hash.Add(employmentEndDate);
            return hash.ToHashCode();
        }
    }
}