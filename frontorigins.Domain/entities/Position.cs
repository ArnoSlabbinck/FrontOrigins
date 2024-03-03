using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Position : BaseEntity
    {
        private string title;

        private string description;

        private DateTime startdate;
        private DateTime? enddate;

        public Position(long id) : base(id)
        {
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Startdate { get => startdate; set => startdate = value; }
        public DateTime? Enddate { get => enddate; set => enddate = value; }
    }
}