using System.Globalization;
using System.Net.Sockets;

namespace _02_Linq
{
    public class Emp
    {
        public int Id;

        public string Name;

        public string Address;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new List<Emp>
            {
                new Emp()  { Id = 1, Name = "Kumar", Address = "Satara" },
                new Emp()  { Id = 2, Name = "Gaurav", Address = "Pune" },
                new Emp()  { Id = 3, Name = "Sai", Address = "Mumbai" },
                new Emp()  { Id = 4, Name = "Sairaj", Address = "Dubai" },
                new Emp()  { Id = 5, Name = "Vishwajeet", Address = "Rethare" },
            };
            
            var result = emps.Where(e => e.Address.EndsWith("i"));
            foreach(var e in result)
            {
                Console.WriteLine(e.Name+ "-"+ e.Address);
            }
        }
    }
}