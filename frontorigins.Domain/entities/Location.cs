using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Location : BaseEntity
    {

        private string streetAddress;

        private string city;

        private string state;

        private string zipCode;

        private string country;

        public Location(long id) : base(id)
        {
        }

        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string Country { get => country; set => country = value; }
    }
}