using frontorigins.Domain.common;

namespace frontorigins.Domain.aggregates
{
    public record Address 
    {

        private string streetAddress { get; }

        public string city { get; }

        public string state { get; }

        public string zipCode { get; }


        public string country { get; }

        private Address(string streetAddress, string city, string state, string zipCode, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.country = country;
        }

        public static Address Create(string streetAddress, string city, string state, string zipCode, string country)
        {
            // Check street and zipCode validity

            return new Address(streetAddress, city, state, zipCode, country);
        }
    }
}