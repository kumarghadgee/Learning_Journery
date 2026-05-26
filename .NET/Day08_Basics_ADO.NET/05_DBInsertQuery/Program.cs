using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace _05_DBInsertQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionDetails = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=kdacdb;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection conn = new SqlConnection(connectionDetails);

            Console.WriteLine("Enter the Name : ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter the Address : ");
            string Address = Console.ReadLine();

            string queryFormat = "Insert into Emp (Name,Address) Values ('{0}' , '{1}')";
            string query = string.Format(queryFormat, Name, Address);

            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"rowsAffected : {rowsAffected} rows inserted.");

            conn.Close();
        }
    }
}