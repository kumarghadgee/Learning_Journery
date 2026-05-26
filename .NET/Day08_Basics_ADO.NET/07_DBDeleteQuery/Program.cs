using Microsoft.Data.SqlClient;

namespace _07_DBDeleteQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionSet = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=kdacdb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSet);

            Console.WriteLine("Enter the No you want to delete.");
            int no = int.Parse(Console.ReadLine());

            string queryFormat = "DELETE FROM Emp WHERE No = ('{0}')";
            string query = string.Format(queryFormat, no);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"rowsAffected : {rowsAffected} rows Deleted");

            connection.Close();
        }
    }
}