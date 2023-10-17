using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]

	public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
			GuideValidator validationRules = new GuideValidator();
			ValidationResult validationResult = validationRules.Validate(guide);
            if (validationResult.IsValid)
            {
				_guideService.Tadd(guide);
				return RedirectToAction("Index");
			}
            else
            {
                foreach(var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        [HttpGet]
        public ActionResult EditGuide(int id)
        {
            var values = _guideService.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Index");
        }
    }
}
