using Microsoft.AspNetCore.Mvc;
using _001DemoMVC.Filters;
namespace _001DemoMVC.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
