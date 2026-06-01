using _01_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace _01_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : Controller
    {
        KaradDbContext db = new KaradDbContext();

        [HttpGet]
        public IEnumerable<Emp> Get()
        {
            return db.Emps.ToList();
        }

        [HttpGet("{id}")]
        public Emp Get(int id)
        {
            return db.Emps.ToList().Find(e => e.No == id);
        }

        [HttpPost]
        public void Post([FromBody]Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Emp emp)
        {
            Emp e = db.Emps.ToList().Find(e => e.No == id);
            if (e != null)
            {
                e.Name = emp.Name;
                e.Address = emp.Address;
                db.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Emp e = db.Emps.ToList().Find(e => e.No == id);
            if(e != null)
            {
                db.Emps.Remove(e);
                db.SaveChanges();
            }
        }
    }
}
