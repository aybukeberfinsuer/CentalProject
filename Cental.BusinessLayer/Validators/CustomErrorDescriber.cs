using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Validators
{
	public class CustomErrorDescriber:IdentityErrorDescriber
	{

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError
			{
				Description = "Password need to lower letter."
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError
			{
				Description = "Password need to digit."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError
			{
				Description = "Password need to upper letter."
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError
			{
				Description = "Password need to alphanumeric character."
			};
		}

		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError
			{
				Description=$"Password should be {length} character."
			};
		}

		public override IdentityError DuplicateEmail(string email)
		{
			return new IdentityError
			{
				Description = $"{email} this email is already using."
			};
		}
	}
}
