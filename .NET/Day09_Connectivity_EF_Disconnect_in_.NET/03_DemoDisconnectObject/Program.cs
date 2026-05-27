using System.Data;

namespace _03_DemoDisconnectObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable("Emp");

            DataColumn col1 = new DataColumn("No", typeof(int));
            DataColumn col2 = new DataColumn("Name", typeof(string));
            DataColumn col3 = new DataColumn("Address", typeof(string));

            table.Columns.Add(col1);
            table.Columns.Add(col2);
            table.Columns.Add(col3);

            table.PrimaryKey = new DataColumn[] { col1 };

            DataRow row1 = table.NewRow();
            row1["No"] = 101;
            row1["Name"] = "Kumar";
            row1["Address"] = "Satara";

            DataRow row2 = table.NewRow();
            row2["No"] = 102;
            row2["Name"] = "Gaurav";
            row2["Address"] = "Shahupuri";

            DataRow row3 = table.NewRow();
            row3["No"] = 103;
            row3["Name"] = "Sairaj";
            row3["Address"] = "Samata Park";

            table.Rows.Add(row1);
            table.Rows.Add(row2);
            table.Rows.Add(row3);
        }
    }
}