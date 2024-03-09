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

        public override bool Equals(object? obj)
        {
            return obj is Position position &&
                   base.Equals(obj) &&
                   Id == position.Id &&
                   CreatedDate == position.CreatedDate &&
                   ModifiedDate == position.ModifiedDate &&
                   title == position.title &&
                   description == position.description &&
                   startdate == position.startdate &&
                   enddate == position.enddate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, CreatedDate, ModifiedDate, title, description, startdate, enddate);
        }
    }
}