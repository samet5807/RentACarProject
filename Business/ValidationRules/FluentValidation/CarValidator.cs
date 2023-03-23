﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public  class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MinimumLength(3);
            RuleFor(p=> p.CarId).NotEmpty();
            RuleFor(p=> p.BrandId).NotEmpty();
            RuleFor(p=> p.ModelYear).NotEmpty();
            RuleFor(p=> p.DailyPrice).NotEmpty();
            RuleFor(p=> p.DailyPrice).GreaterThan(0);
            RuleFor(p=> p.ColorId).NotEmpty();

          
        }
    }
}
