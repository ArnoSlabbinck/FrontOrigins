﻿using FluentValidation;
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
        
        }
    }
}