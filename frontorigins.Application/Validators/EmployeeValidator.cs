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
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator() 
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Employee needs to have a firstname")
                .MaximumLength(50);

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Employee needs to have a last name")
                .MaximumLength(50);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email Address is required")
                .EmailAddress().WithMessage("Please an valid Employee Mail address");

            RuleFor(x => x.MobilePhone)
                .NotEmpty()
                .NotNull().WithMessage("Phone Number is required.")
                .MinimumLength(10).WithMessage("PhoneNumber must not be less than 10 characters.")
                .MaximumLength(20).WithMessage("PhoneNumber must not exceed 50 characters.")
                .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid");

            RuleFor(x => x.BankAccountNumber)
                .NotEmpty()
                .CreditCard().WithMessage("Enter a valid credit/debit card number");

            RuleFor(x => x.BirthDate)
                .Must(date => BeAValidAge(date)).WithMessage("An employee can be lower than 18 years old");

            RuleFor(x => x.Address)
                .SetValidator(new AddressValidation());



        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }
    }
}
