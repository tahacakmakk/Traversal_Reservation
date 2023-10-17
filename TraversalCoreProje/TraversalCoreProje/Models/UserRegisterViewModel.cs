using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage ="Lütfen Adınızı Girin")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Girin")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Adresinizi Girin")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]
		[Compare("Password",ErrorMessage ="Şifreler Eşleşmiyor")]
		public string ConfirmPassword { get; set; }
	}
}
