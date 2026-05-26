using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_ORMAttributes;

namespace _02_ORMPocos
{
    [Table(TableName = "Employee")]

    public class Emp
    {
        [Column(ColumnName = "No", ColumnType = "int")]
        public int No { get; set; }

        [Column(ColumnName = "Name", ColumnType = "string")]
        public string Name { get; set; }

        [Column(ColumnName = "Address", ColumnType = "string")]
        public string Address { get; set; }
    }
    [Table(TableName = "Department")]
    public class Dept
    {
        [Column(ColumnName = "DNo" , ColumnType ="int")]
        public int DNo { get; set; }

        [Column(ColumnName = "DName", ColumnType ="string")]
        public string DName { get; set; }
    }
}
