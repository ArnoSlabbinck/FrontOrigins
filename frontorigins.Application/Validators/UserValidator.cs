using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Username is required")
                .MaximumLength(20);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("An Email address is required")
                .EmailAddress().WithMessage("Enter a valid Mail Address")
                .MaximumLength(50);

            RuleFor(x => x.Employee)
                .SetValidator(new EmployeeValidator());

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull().WithMessage("Phone Number is required.")
                .MinimumLength(10).WithMessage("PhoneNumber must not be less than 10 characters.")
                .MaximumLength(20).WithMessage("PhoneNumber must not exceed 20 characters.")
                .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid");

            

        }
    }
}
