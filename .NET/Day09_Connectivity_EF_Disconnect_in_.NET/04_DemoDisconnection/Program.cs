using Microsoft.Data.SqlClient;
using System.Data;

namespace _04_DemoDisconnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KDACDB;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Emp",conn);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);

            da.Fill(ds, "Emp");

            Console.WriteLine("Enter No of the Emp to Update ");
            int no =  Convert.ToInt32(Console.ReadLine());

            DataRow row = ds.Tables["Emp"].Rows.Find(no);
            if (row != null)
            {
                Console.Write("Enter the Name : ");
                row["Name"] = Console.ReadLine();

                Console.WriteLine("Enter the Address : ");
                row["Address"] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Record not Found....");
            }
            da.Update(ds, "Emp");

        }
    }
}