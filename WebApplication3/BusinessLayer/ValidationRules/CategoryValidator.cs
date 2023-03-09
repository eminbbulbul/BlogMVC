using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidator:AbstractValidator<Category>
	{
		public CategoryValidator()
		{

			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı boş geçilemez ");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori İçerik boş geçilemez");
			RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girin");
			RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen en fazla 150 karakter girin");
		}

	}
}
