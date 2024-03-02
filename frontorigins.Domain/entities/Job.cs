using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Job : BaseEntitiy
    {
        private string title { get; set; }

        private string description { get; set; }

        private DateTime startdate { get; set; }

        private DateTime? enddate { get; set; }
        public Job() { }
    }
}