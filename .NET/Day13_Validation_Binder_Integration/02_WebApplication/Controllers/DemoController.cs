using Microsoft.AspNetCore.Mvc;
using _02_WebApplication.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace _02_WebApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create([ModelBinder(typeof(CustomModelBinder))] List<Emp> emp)
        {
            KaradDbContext db = new KaradDbContext();
            foreach(var item in emp)
            {
                db.Emps.Add(item);
                db.SaveChanges();
            }
            return Redirect("/Home/Index");

        }

        public IActionResult Test()
        {
            return View();
        }
    }

    public class CustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var model = new List<Emp>();

            Emp emp1 = new Emp();
            emp1.Name = bindingContext.ValueProvider.GetValue("Name1").FirstValue;
            emp1.Address = bindingContext.ValueProvider.GetValue("Address1").FirstValue;

            Emp emp2 = new Emp();
            emp2.Name = bindingContext.ValueProvider.GetValue("Name2").FirstValue;
            emp2.Address = bindingContext.ValueProvider.GetValue("Address2").FirstValue;

            model.Add(emp1);
            model.Add(emp2);

            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
