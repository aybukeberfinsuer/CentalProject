using Cental.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Validators
{
	public class CarValidator:AbstractValidator<Car>
	{
		public CarValidator()
		{
			RuleFor(x => x.ModelName).NotEmpty().WithMessage("Model Name can't be empty.");
			RuleFor(x => x.Transmission).NotEmpty().WithMessage("Transmission type can't be empty.");
			RuleFor(x => x.GasType).NotEmpty().WithMessage("Gas type type can't be empty.");
			RuleFor(x => x.Price).NotEmpty().WithMessage("Price can't be empty.");
			RuleFor(x => x.Year).NotEmpty().WithMessage("Year can't be empty.");
			RuleFor(x => x.Kilometer).NotEmpty().WithMessage("Kilometer  can't be empty.");
			RuleFor(x => x.GearType).NotEmpty().WithMessage("Gear type can't be empty.");
		}
	}
}
