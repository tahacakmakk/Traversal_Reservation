using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccsessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Destination
{
    public class _GuideDetail : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetail(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _guideService.GetByID(1);
            return View(values);
        }
    }
}
