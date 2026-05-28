using Microsoft.Data.SqlClient;
using System.Data;

namespace _02_DBProgrammingStoredProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=KaradDB;Integrated Security=True;");

            connection.Open();

            SqlCommand command = new SqlCommand("AddEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 =
            new SqlParameter("@name", SqlDbType.VarChar, 50);

            SqlParameter param2 =
            new SqlParameter("@address", SqlDbType.VarChar, 50);

            param1.Value = "Yuvraj";
            param2.Value = "Karad";

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);

            command.ExecuteNonQuery();

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}