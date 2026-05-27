using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _01_DemoCrudOperations
{
    internal class EmpOps
    {
        public List<Emp> GetData()
        {
            List<Emp> emps = new List<Emp>();

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KDACDB;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("Select * From Emp",connection);

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                Emp emp = new Emp();
                emp. No = Convert.ToInt32(read["No"]);
                emp.Name = read["Name"].ToString();
                emp.Address = read["Address"].ToString();

                emps.Add(emp);
            }
            connection.Close();
            return emps;
        }

        public Emp SearchData(int no)
        {
            var emps = GetData();
            var result = (from e in emps
                         where e.No == no
                         select e);

            if(result.Count() > 0)
            {
                return result.First();
            }
            else
            {
                return null;
            }
        }
        public int AddData()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KDACDB;Integrated Security=True");

            Console.Write("Enter the Name You Want to Add : ");
            string name = Console.ReadLine();

            Console.Write("Enter the Address You Want to Add : ");
            string address = Console.ReadLine();

            connection.Open();

            string queryFormat = "INSERT INTO Emp (Name,Address) VALUES ('{0}','{1}')";
            string query = string.Format(queryFormat, name, address);

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine($"rowsAffected : {rowsAffected} rows Inserted");

            connection.Close();
            return rowsAffected;
        }

        public int UpdateData()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KDACDB;Integrated Security=True");

            Console.Write("Enter the Emp No. you wanted to Update : ");
            int no = int.Parse(Console.ReadLine());

            var emp = SearchData(no);
            Console.WriteLine($"Old Name : {emp.Name}");

            Console.WriteLine($"Old Address : {emp.Address}");

            Console.Write("Enter the Name you want to Update : ");
            string name = Console.ReadLine();

            Console.Write("Enter the Address you want to Update : ");
            string address = Console.ReadLine();

            connection.Open();

            string queryFormat = "UPDATE Emp SET Name = ('{0}') , Address = ('{1}') WHERE No = ('{2}')";
            string query = string.Format(queryFormat, name, address, no);

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"rowsAffected : {rowsAffected} rows Updated");

            connection.Close();
            return rowsAffected;
        }

        public int DeleteData()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KDACDB;Integrated Security=True");

            var emp = GetData();
            var result = (from e in emp
                         select e);

            foreach (var en in result)
            {
                Console.WriteLine($"No : {en.No}, Name = {en.Name}, Address = {en.Address}");
            }

            Console.Write("Enter the No you Want to Delete : ");
            int no = int.Parse(Console.ReadLine());

            connection.Open();

            string queryFormat = "DELETE FROM Emp Where No = '{0}'";
            string query = string.Format(queryFormat,no);

            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }
    }
}
