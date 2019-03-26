using Microsoft.AspNetCore.Mvc;

namespace BoilerplateCore.Web.Controllers
{
    public class HomeController : BoilerplateCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Osobe()
        {
            return View();
        }

        public ActionResult Kancelarije()
        {
            return View();
        }

        public ActionResult Uredjaji()
        {
            return View();
        }

        public ActionResult KoristeniUredjaji()
        {
            return View();
        }
    }
}