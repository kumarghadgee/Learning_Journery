using _02_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using _02_WebApplication.Filters;
namespace _02_WebApplication.Controllers
{
    [AuthFilter]
    public class HomeController : Controller
    {
        KaradDbContext db = new KaradDbContext();
        public IActionResult Index()
        {
            var loggedInUserName = HttpContext.Session.GetString("UserName");
            ViewBag.LoggedInUserName = loggedInUserName;
            return View("Index",db.Emps.ToList());
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult AfterCreate(Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Emps.Add(emp);
                db.SaveChanges();
                return Redirect("/Home/Index");
            }
            else
            {
                return View("Create", emp);
            }
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
                    return Redirect("/Home/Index");
                }
            }
            else
            {
                return Redirect("/Home/Index");
            }
        }

        public IActionResult AfterEdit(Emp emp)
        {
            var empTobeUpdated = db.Emps.Find(emp.No);
            if (empTobeUpdated != null)
            {
                empTobeUpdated.Name = emp.Name;
                empTobeUpdated.Address = emp.Address;
                db.SaveChanges();
            }
            return Redirect("/Home/Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var emp = db.Emps.Find(id);
                if (id != null)
                {
                    db.Emps.Remove(emp);
                    db.SaveChanges();
                }
            }
            return Redirect("/Home/Index");
        }
    }
}
