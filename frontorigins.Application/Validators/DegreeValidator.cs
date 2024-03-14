using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class DegreeValidator : AbstractValidator<Degree>
    {
        public DegreeValidator() 
        {
            RuleFor(x => x.InstitutionName)
                .NotEmpty().WithMessage("An institution needs to have name")
                .MinimumLength(5)
                .MaximumLength(50);

            RuleFor(x => x.Major)
                .NotEmpty().WithMessage("A major is required")
                .MinimumLength(5)
                .MaximumLength(50);

            RuleFor(x => x.Description)
                .MaximumLength(250).WithMessage("Description can't be more than 250 characters");

            RuleFor(x => x.YearBeginning)
                .NotEmpty().WithMessage("Year of Beginning can't be empty")
                .LessThanOrEqualTo(v => v.YearCompletion).WithErrorCode("Your start year can't lay in the future");

            RuleFor(x => x.YearCompletion)
                .NotEmpty().WithMessage("Year of completion can't be empty")
                .GreaterThan(x => x.YearBeginning).WithErrorCode("The year of completion can't be before year of the beginning");


            
                
        }
    }
}
