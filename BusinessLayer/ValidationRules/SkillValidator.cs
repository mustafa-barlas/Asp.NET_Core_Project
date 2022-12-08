using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{ 
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Deneyim başılıgı boş geçilemez");

            RuleFor(x => x.Value).NotEmpty().WithMessage("Deneyim oranı boş geçilemez");
        }
    }
}
