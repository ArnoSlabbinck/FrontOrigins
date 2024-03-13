using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("A company name is required ")
                .MinimumLength(1)
                .MaximumLength(50);

            RuleFor(x => x.Description)
                .MaximumLength(250);

            


        }
    }
}
