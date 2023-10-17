using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationServie;
        public UserController(IAppUserService appUserService, IReservationService reservationServie)
        {
            _appUserService = appUserService;
            _reservationServie = reservationServie;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetByID(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values= _appUserService.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser p)
        {
            var values = _appUserService.GetByID(p.Id);
            _appUserService.TUpdate(values);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
        {
            return View(new { id });
        }
        public IActionResult ReservationUser(int id)
        {

            var values = _reservationServie.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}

