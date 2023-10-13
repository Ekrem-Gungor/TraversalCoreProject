using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    internal class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Açıklamayı Boş Bırakmayınız!");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Lütfen Açıklamayı Boş Bırakmayınız!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen Açıklamaya En Az '50' Karakterlik Bilgi Giriniz!");
            RuleFor(x => x.Description2).MinimumLength(50).WithMessage("Lütfen Açıklamaya En Az '50' Karakterlik Bilgi Giriniz!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("1500 Kelimeden Fazla Karakter Girişi yaptınız..Lütfen Açıklamayı Kısaltınız!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görseli Boş Bırakmayınız!");
        }
    }
}
