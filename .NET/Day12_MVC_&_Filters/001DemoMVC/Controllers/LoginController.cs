using _001DemoMVC.Filters;
using _001DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _001DemoMVC.Controllers
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
                //You can also add some error message to show on the login page
                ViewBag.ErrorMessage = "Invalid username or password";
                return View("SignIn");
            }
        }

        public IActionResult Signout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Login/SignIn");
        }

        private bool AuthenticateUser(Credentials credentials)
        {
            //Here you can write your logic to authenticate the user
            //For example, you can check the credentials against a database
            //If the credentials are valid, return true, otherwise return false

            if (credentials.UserName == "mahesh" && credentials.Password == "mahesh123")
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
