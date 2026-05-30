using Microsoft.AspNetCore.Mvc.Filters;

namespace _001DemoMVC.Filters
{
    public class AuthFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Check if user is authenticated or not
            //if not authenticated, then redirect to login page

            var isLoggedIn = context.HttpContext.Session.GetString("isloggedin");
            if (isLoggedIn == null || isLoggedIn != "true")
            {
               context.HttpContext.Response.Redirect("/Login/SignIn");
            }

        }
    }
}
