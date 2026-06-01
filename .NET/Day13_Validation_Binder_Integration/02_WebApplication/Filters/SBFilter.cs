using Microsoft.AspNetCore.Mvc.Filters;
using _02_WebApplication.Loggers;
namespace _02_WebApplication.Filters
{
    public class SBFilter : ActionFilterAttribute
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Logger.CurrentLogger.Log(context.HttpContext.Request.Path + "action is Called");

        }

        public void onActionExecuting(ActionExecutingContext context)
        {
            Logger.CurrentLogger.Log(context.HttpContext.Request.Path + "action is getting called");
        }

        public void onResultExecuting(ResultExecutingContext context)
        {
            Logger.CurrentLogger.Log(context.HttpContext.Request.Path + "result is getting called");
        }

        public void onResultExecuted(ResultExecutedContext context)
        {
            Logger.CurrentLogger.Log(context.HttpContext.Request.Path + "result is called");
        }
    }
}
