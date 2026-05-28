using Microsoft.AspNetCore.Mvc;
using _03_DemoMVC.Models;
namespace _03_DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp obj = new Emp() { No = 1, Name = "Kishor", Address = "Pune" };
            return View("XYZ", obj);
        }
    }
}
