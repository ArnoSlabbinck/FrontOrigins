using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator() 
        {
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Enter a good email address");

            RuleFor(x => x.ClientPhone)
                .NotEmpty()
                .NotNull().WithMessage("Phone Number is required.")
                .MinimumLength(10).WithMessage("PhoneNumber must not be less than 10 characters.")
                .MaximumLength(20).WithMessage("PhoneNumber must not exceed 20 characters.")
                .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid");

            RuleFor(x => x.ClientName)
                .NotEmpty().WithMessage("A client needs a name")
                .MinimumLength(1)
                .MaximumLength(40);

            RuleFor(x => x.Address)
                .SetValidator(new AddressValidation());

            RuleFor(x => x.Industry)
                .NotNull().WithMessage("An industry name is required");



        }
    }
}
