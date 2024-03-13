using FluentValidation;
using frontorigins.Domain.aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation() 
        {
            RuleFor(x => x.streetAddress)
                .NotEmpty().WithMessage("A street address is required")
                .MinimumLength(5)
                .MaximumLength(50);

            RuleFor(x => x.city)
                .MinimumLength(5)
                .MaximumLength(50)
                .NotEmpty().WithMessage("A city is required");

            RuleFor(x => x.country)
                .NotEmpty().WithMessage("A country is required")
                .MinimumLength(5)
                .MaximumLength(50);

            RuleFor(x => x.state)
                .NotEmpty().WithMessage("A state is required")
                .MaximumLength(5)
                .MaximumLength(50);

            RuleFor(x => x.zipCode)
                .NotEmpty().WithMessage("A zipcode is required")
                .Matches("@\"^\\d{4}$\"").WithMessage("A zipcode can only be 4 letter code");
        
        }
    }
}
