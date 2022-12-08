using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalı");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter olmalı");


            RuleFor(x  => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

            RuleFor(x => x.age).NotEmpty().WithMessage("Yaş alanı boş geçilelemez");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail Formtında giriniz");

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon alanı boş geçilelemez");
            RuleFor(x => x.Phone).MaximumLength(11).WithMessage("Telefon alanı boş geçilelemez");
            RuleFor(x => x.Phone).MinimumLength(11).WithMessage("Telefon alanı boş geçilelemez");

            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres alanı boş geçilemez");
            RuleFor(x => x.Address).MinimumLength(10).WithMessage("Adres alanı boş geçilemez");

        }
    }
}
