using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar Adi Bos Gecilemez");
            RuleFor(w => w.WriterSurname).NotEmpty().WithMessage("Yazar Soyadi Bos Gecilemez");
            RuleFor(w => w.WriterAbout).NotEmpty().WithMessage("Hakkinda Kismi Bos Gecilemez");
            RuleFor(w => w.WriterTitle).NotEmpty().WithMessage("Unvan Kismi Bos Gecilemez");
            RuleFor(w => w.WriterName).MinimumLength(2).WithMessage("Yazarin Adi En Az 2 Karakterden Olusmalidir");
            RuleFor(w => w.WriterSurname).MaximumLength(50).WithMessage("Yazarin Soyadi En Fazla 50 Karakterden Olusabilir");
        }
    }
}
