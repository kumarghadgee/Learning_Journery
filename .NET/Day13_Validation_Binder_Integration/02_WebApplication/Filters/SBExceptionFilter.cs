using Microsoft.AspNetCore.Diagnostics;
using _02_WebApplication.Loggers;
namespace _02_WebApplication.Filters
{
    public class SBExceptionFilter : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception,CancellationToken cancellationToken) 
        { 
        
            Logger.CurrentLogger.Log("Error Ocurred In.");
            Logger.CurrentLogger.Log(httpContext.Request.Path);
            Logger.CurrentLogger.Log("Details are :");
            Logger.CurrentLogger.Log(exception.Message);

            httpContext.Response.Redirect("/Exception/Error");
            return new ValueTask<bool>(true);
        }
    }
}