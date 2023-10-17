using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
	public class SendContactUsValidator : AbstractValidator<SendMessageDto>
	{
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez !");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı Boş Geçilemez !");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu Alanına en az 5 karakter veri girişi yapmalısınız !");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu Alanına en fazla 100 karakter veri girişi yapabilirsiniz !");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez !");
            RuleFor(x => x.MessageBody).MinimumLength(5).WithMessage("Mesaj Alanına en az 5 karakter veri girişi yapmalısınız !");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez !");
        }
    }
}
