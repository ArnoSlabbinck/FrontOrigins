using frontorigins.Domain.common;
using System.ComponentModel.DataAnnotations;

namespace frontorigins.Domain.aggregates
{
    public record Address 
    {
        [Display(Name = "StreetName")]
        public string streetAddress { get; private set; }

        [Display(Name = "City")]
        public string city { get; private set; }

        [Display(Name = "State")]
        public string state { get; private set; }

        [Display(Name = "Zipcode")]
        public string zipCode { get; private set; }

        [Display(Name = "Country")]
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