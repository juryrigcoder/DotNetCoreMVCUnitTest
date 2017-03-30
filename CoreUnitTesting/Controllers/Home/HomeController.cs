using CoreUnitTesting.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace CoreUnitTesting.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel();
            return View(model);
        }
    }
}