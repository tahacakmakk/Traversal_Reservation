using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
