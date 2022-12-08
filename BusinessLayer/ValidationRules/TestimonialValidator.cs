using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.ClientName).NotEmpty().WithMessage("Çalışan  adı boş geçilemez");

            RuleFor(x => x.Company).NotEmpty().WithMessage("şirket adı boş geçilemez");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage(" Görsel boş geçilemez");

        }
    }
}
