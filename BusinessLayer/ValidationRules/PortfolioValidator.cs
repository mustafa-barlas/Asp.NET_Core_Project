using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("proje adı boş geçlemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("proje adı en az 3 karakter olmalı");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("proje adı en fazla 100 karakter olabilir");

            RuleFor(x => x.Price).NotEmpty().WithMessage("fiyat boş geçilemez");

            RuleFor(x => x.Platform).NotEmpty().WithMessage("platform adı boş geçilemez");
            RuleFor(x => x.Platform).MinimumLength(3).WithMessage("platform adı en az 3 karakter olmalı");

            //RuleFor(x => x.Value).NotEmpty().WithMessage("Tamamlanma oranı boş geçilemez");

        }
    }
}
