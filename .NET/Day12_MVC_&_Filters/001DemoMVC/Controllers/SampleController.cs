using _001DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using _001DemoMVC.Filters;
namespace _001DemoMVC.Controllers
{
    public class SampleController : Controller
    { 
        //http://localhost:5299/Sample/Test?fname=mahesh&lname=pune
        //public IActionResult Test(string fname, string lname)
        public IActionResult Test(IFormCollection collection)
        {
            int id = 0;
            //throw new Exception("this is my exception");
            int  result = 10 / id;

            return null;
        }
        public IActionResult Index()
        {
            Book book = new Book();
            book.ISBN = 1234;
            book.Title = "C# Programming";
            book.Author = "John Doe";

            ViewData["Message"] = "Hi from Method Index";
            ViewData["AnotherMessage"] = "Hi Again!";

            ViewBag.MyBook = book;

            Emp emp = new Emp() { Name = "ABC", Address = "Pune" };
            return View("Index", emp);
        }

        public IActionResult Demo(int? id)
        {
            int? num = 100;
            int? result = num / id;
            return new ContentResult()
            {
                Content = "Result is " + result,
                ContentType = "text/plain"
            };

        }
            //public IActionResult Demo(int? id)
            //{
            //try
            //{
            //    int? num = 100;
            //    int? result = num / id;
            //    return new ContentResult()
            //    {
            //        Content = "Result is " + result,
            //        ContentType = "text/plain"
            //    };
            //}
            //catch (Exception ex)
            //{
            //    return View("Error", ex);
            //}
        //}
    }
}
