using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MailController : Controller
	{
		private readonly IAppUserService _appUserService;

        public MailController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(MailRequest mailRequest)
		{
			MimeMessage mimeMessage = new MimeMessage();
			MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversalcore8@gmail.com");
			mimeMessage.From.Add(mailboxAddressFrom);

			MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBulider = new BodyBuilder();
			bodyBulider.TextBody = mailRequest.Body;
			mimeMessage.Body = bodyBulider.ToMessageBody();
			mimeMessage.Subject = mailRequest.Subject;

			SmtpClient client = new SmtpClient();
			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate("traversalcore8@gmail.com", "oywjwcodfmynihta");
			client.Send(mimeMessage);
			client.Disconnect(true);


			//List<SelectListItem> values = (from x in _appUserService.TGetList()
			//							   select new SelectListItem
			//							   {
			//								   Text = x.Email,
			//								   Value = x.Id.ToString()
			//							   }).ToList();
			//ViewBag.users = values;


			//SelectList userList = new SelectList(_appUserService.TGetList(), "Id", "Email");
			//ViewData["UserID"] = userList;


			//var userList = _appUserService.TGetList().Select(user => new SelectListItem
			//{
			//	Text = user.Email, // Kullanıcı adını veya istediğiniz başka bir özelliği buraya koyabilirsiniz.
			//	Value = user.Id.ToString() // Kullanıcı kimliğini veya benzersiz bir değeri buraya koyun.
			//}).ToList();

			//ViewData["IdList"] = new SelectList(userList, "Value", "Text");


			return View();	

		}
	}
}
//traversalcore8@gmail.com	
//123456Aa-