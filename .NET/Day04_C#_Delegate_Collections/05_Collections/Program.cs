using System.Collections;
using System.Runtime.Intrinsics.Arm;

namespace _05_Collections
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Remove(10);
            list.Insert(0, 300);


            foreach(object obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        static void Main(string[] args)
        {
            Hashtable map = new Hashtable();
            map.Add(1, "Rohan");
            map.Add(2, "Rahul");
            map.Add(3, "Karan");
            map.Add(4, "Shahid");
            map.Remove(1);
            //map.Add(4,"Sahil");

            Console.WriteLine("Enter the roll ");
            int roll = Convert.ToInt32(Console.ReadLine());
            string value = (string)map[roll];
            Console.WriteLine("value : " + value);

            foreach (object obj in map)
            {
                Console.WriteLine(obj);
            }
        }
    }
}