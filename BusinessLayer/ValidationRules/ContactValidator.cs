using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{ 
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");   
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık alanı en az 5 karakter olmalı");   
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık alanı en fazla 50 karakter olmalı");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Mail formatında giriniz");


            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon alanı boş geçilemez");
            RuleFor(x => x.PhoneNumber).MinimumLength(11).WithMessage("Telefon alanı en az 11 karakter olmalı");
            RuleFor(x => x.PhoneNumber).MaximumLength(11).WithMessage("Telefon alanı en fazla 11 karakter olmalı");
        }
    }
}
