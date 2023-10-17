﻿using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]/{id?}")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal()); 
        private readonly UserManager<AppUser> _userManager;

		public ReservationController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> MyCurrentReservation()
        {
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var valuesList = reservationManager.GetListWithReservationByAccepted(values.Id);
			return View(valuesList);
        }




        public async Task<IActionResult> MyOldReservation()
        {
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
			return View(valuesList);
        }


        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList=reservationManager.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }



        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList(); 
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserID = values.Id;
            p.Status = "Onay Bekliyor";
            reservationManager.Tadd(p);
            return RedirectToAction("MyCurrentReservation","Reservation");
        }
    }
}
