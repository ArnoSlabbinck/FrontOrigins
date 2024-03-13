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
                .MaximumLength(250);

            
                
        }
    }
}
