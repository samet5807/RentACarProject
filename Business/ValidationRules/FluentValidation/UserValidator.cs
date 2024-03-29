﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p=> p.UserId).NotEmpty();
            RuleFor(p=> p.FirstName).NotEmpty();
            RuleFor(p=> p.LastName).NotEmpty();           
            RuleFor(p=> p.Email).EmailAddress().NotEmpty();
            RuleFor(p=> p.Password).MinimumLength(10).NotEmpty();
            
        }
    }
}
