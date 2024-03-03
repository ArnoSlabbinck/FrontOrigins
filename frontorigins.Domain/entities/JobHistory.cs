using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class JobHistory : BaseEntity
    {
        private string title;

        private string description;

        private string supervisorName;

        private string supervisorContact;

        private DateTime employementStartDate;
        private DateTime employmentEndDate;

        public JobHistory(long id) : base(id)
        {
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string SupervisorName { get => supervisorName; set => supervisorName = value; }
        public string SupervisorContact { get => supervisorContact; set => supervisorContact = value; }
        public DateTime EmployementStartDate { get => employementStartDate; set => employementStartDate = value; }
        public DateTime EmploymentEndDate { get => employmentEndDate; set => employmentEndDate = value; }
    }
}