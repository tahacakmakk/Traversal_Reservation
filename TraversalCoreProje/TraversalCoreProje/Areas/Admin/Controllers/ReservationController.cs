using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Linq;
using System.Net;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
		private readonly IAppUserService _appUserService;

        public ReservationController(IReservationService reservationService, IAppUserService appUserService)
		{
			_reservationService = reservationService;
			_appUserService = appUserService;
		}

		public IActionResult ApprovalReservation()
        {
            var values = _reservationService.GetListWithReservationByAllWaitApproval();
            return View(values);
        }
        public IActionResult AcceptedReservation()
        {
            var values = _reservationService.GetListWithReservationByAllAccepted();
            return View(values);
        }

        public IActionResult PreviousReservation()
        {
            var values = _reservationService.GetListWithReservationByAllPrevious();
            return View(values);
        }
		public IActionResult ToApprove(int id)
		{
			_reservationService.ChangeToApprove(id);

			return RedirectToAction("AcceptedReservation");
		}

		//public IActionResult ToApprove()
		//{
		//	int id = 1;

		//	// Rezervasyonu ID'si ile alın
		//	var reservation = _reservationService.GetByID(id);

		//	if (reservation != null)
		//	{
		//		// Rezervasyonun kullanıcısını almak için bir veritabanı sorgusu yapın.
		//		var user = _appUserService.GetByID(reservation.AppUserID); // Örnek bir GetUserById metodu kullanıldı.

		//		if (user != null)
		//		{
		//			// Rezervasyon durumunu "onaylandı" olarak değiştirin.
		//			_reservationService.ChangeToApprove(id);

		//			// Kullanıcıya rezervasyonun onaylandığını bildiren e-posta gönderme işlemi.
		//			SendApprovalEmail(user, reservation);

		//			return RedirectToAction("AcceptedReservation");
		//		}
		//	}

		//	// Rezervasyon veya kullanıcı bulunamadıysa, uygun bir işlem yapın.
		//	return NotFound();
		//}
		//private void SendApprovalEmail(AppUser user, Reservation reservation)
		//{
		//	try
		//	{
		//		MimeMessage mimeMessage = new MimeMessage();
		//		MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversalcore8@gmail.com");
		//		mimeMessage.From.Add(mailboxAddressFrom);

		//		MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", user.Email);
		//		mimeMessage.To.Add(mailboxAddressTo);

		//		var bodyBuilder = new BodyBuilder();
		//		bodyBuilder.TextBody = "Sayın " + user.Name + ",\n\nRezervasyonunuz onaylandı.";
		//		mimeMessage.Body = bodyBuilder.ToMessageBody();
		//		mimeMessage.Subject = "Rezervasyon Onaylandı";

		//		SmtpClient client = new SmtpClient();
		//		client.Connect("smtp.gmail.com", 587, false);
		//		client.Authenticate("traversalcore8@gmail.com", "oywjwcodfmynihta");
		//		client.Send(mimeMessage);
		//		client.Disconnect(true);
		//	}
		//	catch (Exception ex)
		//	{
		//		// E-posta gönderme sırasında oluşan hataları işleyin veya loglayın.
		//		// Gerektiğinde özel işlem yapabilirsiniz.
		//	}
		//}
	}
}
