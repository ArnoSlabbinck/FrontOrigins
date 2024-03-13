using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.Mail)
                .EmailAddress().WithMessage("Please enter a valid email address")
                .NotEmpty().WithMessage("An Email address is required");

            RuleFor(x => x.Sector)
                .Empty().WithMessage("A Departement name is required")
                .MinimumLength(5)
                .MaximumLength(50);

            RuleFor(x => x.Location)
                .SetValidator(new AddressValidation());


        }
    }
}
