using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class TestimonialController : Controller
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public IActionResult Index()
		{
			var values = _testimonialService.TGetList();
			return View(values);
		}

		public IActionResult DeleteTestimonial(int id)
		{
			var values = _testimonialService.GetByID(id);
			_testimonialService.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.Tadd(testimonial);
			return RedirectToAction("Index");
		}
	}
}
