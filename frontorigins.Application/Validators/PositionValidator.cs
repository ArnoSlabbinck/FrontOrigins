using FluentValidation;
using frontorigins.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.Validators
{
    public class PositionValidator : AbstractValidator<Position>
    {
        public PositionValidator() 
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("A title is required")
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("Description can only be have 200 characters");


        }
    }
}
