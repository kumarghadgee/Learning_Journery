using Microsoft.AspNetCore.Mvc.Filters;

namespace _02_WebApplication.Filters
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var isLoggedIn = context.HttpContext.Session.GetString("isloggedin");
            if(isLoggedIn == null || isLoggedIn != "true")
            {
                context.HttpContext.Response.Redirect("/Login/SignIn");
            }
        }
        
    }
}
