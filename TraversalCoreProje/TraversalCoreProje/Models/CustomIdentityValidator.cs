using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length) => new IdentityError 
		{
			Code = "PasswordTooShort", 
			Description = $"Parola en az {length} karakter olmalıdır !" 
		};

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola En Az 1 Büyük Harf İçermelidir !"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola En Az 1 Küçük Harf İçermelidir !"
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = $"Parola En Az 1 Rakam ('0'-'9') İçermelidir !"
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = $"Parola En Az 1 Sembol ('*'-'?') İçermelidir !"
			};
		}

	}
}
