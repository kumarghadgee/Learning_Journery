using Microsoft.AspNetCore.Diagnostics;
using _001DemoMVC.Loggers;
namespace _001DemoMVC.Filters
{
    public class SBExceptionFilter : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            Logger.CurrentLogger.Log("Error Occured in : ");          
            Logger.CurrentLogger.Log(httpContext.Request.Path);
            Logger.CurrentLogger.Log("Details are: ");
            Logger.CurrentLogger.Log(exception.Message);

            httpContext.Response.Redirect("/Exception/Error");
            return new ValueTask<bool>(true);
            
        }
    }
}
