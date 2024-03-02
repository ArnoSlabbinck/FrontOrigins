using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class JobHistory : BaseEntitiy
    {
        private string title { get; set; }

        private string description { get; set; }

        private string supervisorName { get; set; }

        private string supervisorContact { get; set; }

        private DateTime employementStartDate { get; set; }

        private DateTime employmentEndDate { get; set; }
        public JobHistory() { }
    }
}