using Microsoft.AspNetCore.Mvc;

namespace FarmStore.Controllers
{
    public class FarmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Stpre()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }



    }
}