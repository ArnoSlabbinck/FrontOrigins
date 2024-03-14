using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class WorkExperienceValidator : AbstractValidator<WorkExperience>
    {
        public WorkExperienceValidator() 
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull().WithMessage("A title is required")
                .MinimumLength(5)
                .MaximumLength(50);


            RuleFor(x => x.CompanyName)
                .NotEmpty()
                .NotNull().WithMessage("A company name is required")
                .MinimumLength(1)
                .MaximumLength(50);

            RuleFor(x => x.EmployementStartDate)
                .NotEmpty().WithMessage("An Employement Start date is required")
                .LessThanOrEqualTo(x => x.EmploymentEndDate);
        }
    }
}
