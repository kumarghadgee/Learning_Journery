using Microsoft.Data.SqlClient;
using System.Globalization;

namespace _06_DBUpdateQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionDetail = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=kdacdb;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection connect = new SqlConnection(connectionDetail);

            Console.WriteLine("Enter the No of Employee Wanted to Update.");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name You want to Update.");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address You want to Update.");
            string address = Console.ReadLine();

            string queryFormat = "UPDATE Emp SET Name = ('{0}'), Address = ('{1}') WHERE No = ('{2}')";
            string query = string.Format(queryFormat, name, address, no);

            connect.Open();

            SqlCommand command = new SqlCommand(query, connect);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"rowsAffected : {rowsAffected} rows Updated");

            connect.Close();
        }
    }
}