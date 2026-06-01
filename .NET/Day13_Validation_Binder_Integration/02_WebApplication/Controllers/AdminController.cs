using Microsoft.AspNetCore.Mvc;

namespace _02_WebApplication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
