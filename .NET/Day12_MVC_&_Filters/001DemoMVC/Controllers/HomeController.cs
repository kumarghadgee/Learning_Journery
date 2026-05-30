using Microsoft.AspNetCore.Mvc;
using _001DemoMVC.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using _001DemoMVC.Filters;
using Microsoft.AspNetCore.Authorization;
namespace _001DemoMVC.Controllers
{
    [AuthFilter]
    public class HomeController : Controller //BaseController
    {
        KaradDbContext db = new KaradDbContext();

        #region Old - Filter Code 

        //public override void OnActionExecuting(ActionExecutingContext context)
        //{

        //    //context.HttpContext.Request.path
        //    //Write this into some log file
        //}

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    //context.HttpContext.Request.path
        //    //Write this into some log file
        //}

        #endregion

      
        public IActionResult Index()
        {
            var loggedInUserName = HttpContext.Session.GetString("UserName");

            ViewBag.LoggedInUserName = loggedInUserName;
            return View("Index", db.Emps.ToList());
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        //public IActionResult AfterCreate([ModelBinder(typeof(MyModelBinder))] Emp emp)
        public IActionResult AfterCreate(Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();

            return Redirect("/Home/Index");
        }


        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var emp = db.Emps.Find(id);
                if (emp != null)
                {
                    return View("Edit", emp);    
                }
                else
                {
                    //Message to user that data not found to be displayed here!
                    //code is yet to be done
                    return Redirect("/Home/Index");
                }
            }
            else
            {
                //Message to user that data not found to be displayed!
                //code is yet to be done
                return Redirect("/Home/Index");
            }
        }

        public IActionResult AfterEdit(Emp emp)
        {
            var empToBeUpdated = db.Emps.Find(emp.No);
            if (empToBeUpdated != null)
            {
                empToBeUpdated.Name = emp.Name;
                empToBeUpdated.Address = emp.Address;
                db.SaveChanges();
            }

            return Redirect("/Home/Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var emp = db.Emps.Find(id);
                throw new Exception("my exception");
                if (emp != null)
                {
                    db.Emps.Remove(emp);
                    db.SaveChanges();
                }
            }
            return Redirect("/Home/Index");
        }

    }

   

    //public class MyModelBinder : IModelBinder
    //{
    //    public Task BindModelAsync(ModelBindingContext bindingContext)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Anything
    //{
    //    public string Name { get; set; }
    //    public string Address { get; set; }
    //    public int SomeNo { get; set; }
    //}
}
