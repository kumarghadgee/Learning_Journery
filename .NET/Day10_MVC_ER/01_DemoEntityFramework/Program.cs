using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using _01_DemoEntityFramework.Pocos;
namespace _01_DemoEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KaradDbContext context = new KaradDbContext();

            var Address = "Pune";

            var data = context.SPGetEmployeeResultHolders.FromSqlInterpolated($"exec GetEmployeeInfo {Address}").ToList();

            foreach (var e in data)
            {
                Console.WriteLine(e.No + " -- "+ e.Name);
            }
        }
    }
}