using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("AboutUs");
        }

        public IActionResult Content()
        {
            //return Content("Retornando o conteúdo em formato string");

            return RedirectToAction("Index", "Home");
        }
    }
}
