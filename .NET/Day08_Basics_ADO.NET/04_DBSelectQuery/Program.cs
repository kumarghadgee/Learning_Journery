using Microsoft.Data.SqlClient;

namespace _04_DBSelectQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=kdacdb;TrustServerCertificate=True";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=kdacdb;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand query = new SqlCommand("Select * From Emp",connection);

            SqlDataReader reader = query.ExecuteReader();

            List<Emp> emp = new List<Emp>();

            while (reader.Read())
            {
                Emp emps = new Emp()
                {
                    No = (int)reader["No"],
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()
                };
                emp.Add(emps);
            }

            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["No"]} {reader["Name"]} {reader["Address"]}");
            //}

            foreach(var e in emp)
            {
                Console.WriteLine($"{e.No}. {e.Name} -> {e.Address}");
            }

            connection.Close();




        }
        
    }

    public class Emp
    {
        public int No { get; set; }

        public string Name { get; set; }
        
        public string Address { get; set; }
    }
}