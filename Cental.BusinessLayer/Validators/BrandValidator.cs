using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Validators
{
	public class BrandValidator:AbstractValidator<Brand>
	{
		public BrandValidator()
		{
			RuleFor(x => x.BrandName)
				.NotEmpty().WithMessage("Brand name can't be empty.")
				.MinimumLength(2).WithMessage("Brand Name must be min 2 character");
		}

	}
}
