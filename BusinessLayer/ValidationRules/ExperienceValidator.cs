using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator() 
        { 
            RuleFor(x => x.Name).NotEmpty().WithMessage("Deneyim adı boş geçilemez");    
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("Deneyim adı en az 10 karakter olmalı");

            RuleFor(x => x.Date).NotEmpty().WithMessage("Deneyim tarihi boş geçilemez");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Deneyim görsel alanı boş geçilemez");

        }
    }
}
