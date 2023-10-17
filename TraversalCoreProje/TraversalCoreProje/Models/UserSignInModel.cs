using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserSignInModel
	{
        [Required(ErrorMessage ="Lütfen Kullanıc Adını Giriniz")]
        public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }

	}
}
