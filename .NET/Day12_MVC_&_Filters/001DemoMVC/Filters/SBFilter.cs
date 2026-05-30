using Microsoft.AspNetCore.Mvc.Filters;
using _001DemoMVC.Loggers;
namespace _001DemoMVC.Filters
{
    #region Filter Implementation Code 1
    //[AttributeUsage(AttributeTargets.Class, Inherited = true)]
    //public class SBFilter : Attribute, IActionFilter, IResultFilter
    //{
    //    public void OnActionExecuted(ActionExecutedContext context)
    //    {
    //        Logger.CurrentLogger.Log(context.HttpContext.Request.Path + " is called.");
    //    }

    //    public void OnActionExecuting(ActionExecutingContext context)
    //    {
    //        Logger.CurrentLogger.Log(context.HttpContext.Request.Path + " is getting called.");
    //    }

    //    public void OnResultExecuted(ResultExecutedContext context)
    //    {
    //        Logger.CurrentLogger.Log("UI Is Created and about to be dispatched to client / browser");
    //    }

    //    public void OnResultExecuting(ResultExecutingContext context)
    //    {
    //        Logger.CurrentLogger.Log("UI Is getting created!");
    //    }
    //}

    #endregion

    #region Filter Implementation Code 2
    public class SBFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Logger.CurrentLogger.Log(context.HttpContext.Request.Path + " is called.");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Logger.CurrentLogger.Log(context.HttpContext.Request.Path + " is getting called.");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Logger.CurrentLogger.Log("UI Is Created and about to be dispatched to client / browser");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Logger.CurrentLogger.Log("UI Is getting created!");
        }
    }
    #endregion
}

