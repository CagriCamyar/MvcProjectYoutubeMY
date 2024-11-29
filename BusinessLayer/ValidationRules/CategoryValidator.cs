using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c=> c.CategoryName).NotEmpty().WithMessage("Kategori Adi Bos Gecilemez");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Aciklama Bos Gecilemez");
            RuleFor(c=> c.CategoryName).MinimumLength(3).WithMessage("Kategori Adi En Az 3 Karakterden Olusmalidir");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage("Kategori Adi En Fazla 20 Karakterden Olusabilir");
        }
    }
}
