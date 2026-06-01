using Microsoft.AspNetCore.Mvc;
using _02_WebApplication.Models;
namespace _02_WebApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        public IActionResult AfterSignIn(Credentials credentials)
        {
            if (AuthenticateUser(credentials))
            {
                HttpContext.Session.SetString("isloggedin", "true");
                HttpContext.Session.SetString("UserName", credentials.UserName);
                return Redirect("/Home/Index");
            }
            else
            {
                return View("SignIn");
            }
        }

        public IActionResult Signout()
        {
            HttpContext.Session.Clear();
            return Redirect("/LogIn/SignIn");
        }

        private bool AuthenticateUser(Credentials credentials)
        {
            if(credentials.UserName == "Mahesh" && credentials.Password == "mahesh123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
