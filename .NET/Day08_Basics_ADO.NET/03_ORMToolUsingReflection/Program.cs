using _01_ORMAttributes;
using _02_ORMPocos;
using System.Reflection;

namespace _03_ORMToolUsingReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\\.net Prac\\Day08\\Day08Soln\\02_ORMPocos\\bin\\Debug\\02_ORMPocos.dll";

            Assembly assembly = Assembly.LoadFrom(path);
            Type[] alltypes = assembly.GetTypes();
            string query = "";

            foreach (Type type in alltypes)
            {
                query = query + "CREATE TABLE ";
                var AttributesOnType = type.GetCustomAttributes();
                foreach (var attribute in AttributesOnType)
                {
                    if(attribute is Table)
                    {
                        Table table = (Table)attribute;
                        query = query + table.TableName;
                        break;
                    }
                }
                PropertyInfo[] allProperties = type.GetProperties();

                query = query + " (";
                
                foreach(var property in allProperties)
                {
                    var propertyAttribuutes = property.GetCustomAttributes();
                    foreach(var PropertyAttribute in propertyAttribuutes)
                    {
                        Column column = (Column)PropertyAttribute;
                        query = query + column.ColumnName + " " + column.ColumnType + ",";
                        break;
                    }
                }
                query = query.TrimEnd(',');
                query = query + ");";
            }
            Console.WriteLine(query);
        }
    }
}