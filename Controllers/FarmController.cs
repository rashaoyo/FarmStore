using Microsoft.AspNetCore.Mvc;

namespace FarmStore.Controllers
{
    public class FarmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FarmStoreView()
        {
            return View();
        }

        public IActionResult CartView()
        {
            return View();
        }



    }
}