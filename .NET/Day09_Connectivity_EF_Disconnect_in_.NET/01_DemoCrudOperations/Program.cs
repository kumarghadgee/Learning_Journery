using Microsoft.Data.SqlClient;
namespace _01_DemoCrudOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpMenu menu = new EmpMenu();
            menu.Menu();
        }
    }
}