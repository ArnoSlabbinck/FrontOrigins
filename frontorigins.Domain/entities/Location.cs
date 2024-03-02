using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Location : BaseEntitiy
    {

        private string streetAddress { get; set; }

        private string city { get; set; }

        private string state { get; set; }

        private string zipCode { get; set; }

        private string country { get; set; }

        public Location()
        {

        }
    }
}