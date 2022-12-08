using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
                RuleFor(x => x.Name).NotEmpty().WithMessage("Sosyal medya adı boş geçilemez");

                RuleFor(x => x.Url).NotEmpty().WithMessage("Sosyal medya adresi boş geçilemez");

                RuleFor(x => x.Icon).NotEmpty().WithMessage("Sosyal medya iconu boş geçilemez");

        }
    }
}
