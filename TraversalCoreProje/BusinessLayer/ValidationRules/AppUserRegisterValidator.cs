using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
	{
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez !");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez !");
            RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez !");
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez !");
            RuleFor(x=>x.Password ).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez !");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez !");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.UserName).MaximumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler Birbiri ile Uyuşmuyor");
        }
    }
}
