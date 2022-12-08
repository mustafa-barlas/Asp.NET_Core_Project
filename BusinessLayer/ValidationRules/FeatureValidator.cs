using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(x => x.Header).NotEmpty().WithMessage("Öne çıkanlar başlıgı boş geçilemez");


            RuleFor(x => x.Name).NotEmpty().WithMessage("Öne çıkanlar adı boş geçilemez");


            RuleFor(x => x.Title).NotEmpty().WithMessage("Öne çıkanlar açıklaması boş geçilemez");
        }
    }
}
