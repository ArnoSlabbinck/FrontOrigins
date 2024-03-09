using frontorigins.Domain.common;

namespace frontorigins.Domain.aggregates
{
    public record Address 
    {
        public string streetAddress { get; private set; }
        public string city { get; private set; }
        public string state { get; private set; }
        public string zipCode { get; private set; }

        public string country { get; private set; }
        public Address(string streetAddress, string city, string state, string zipCode, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.country = country;
        }

    }
}