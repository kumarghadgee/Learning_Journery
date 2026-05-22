using System.Globalization;

namespace _04_Nullable
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int? num = null;
            Console.WriteLine(num);

            Nullable<int> num2 = 256;
            if (num2.HasValue)
            {
                Console.WriteLine("Print num2 : " + num2);
            }
            else
            {
                Console.WriteLine("Num is Null");
            }

            Nullable<int> num3 = null;
            if (num3.HasValue)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine("Num3 is null");
            }
        }
        static void Main2(string[] args)
        {
            string s = "Sunbeam";
            Console.WriteLine("String = " + s.ToUpper());

            string? s1 = null;
            //Console.WriteLine("String : " + s1.ToUpper()); ####  System.NullReferenceException ####
            Console.WriteLine("String : " + s1);

            string? s2 = null;
            Console.WriteLine("String : " + s1?.ToUpper()); // OK

        }

        static void Main(string[] args)
        {
            //COALESCE 

            string addr = null;
            string defAddr = "Pune";
            string person1_addr = addr;

            if (addr == null)
                person1_addr = defAddr;

            Console.WriteLine("person1_addr : " + person1_addr);

            string person2 = addr == null ? defAddr : addr;
            Console.WriteLine("Person 2 : " + person2);

            string person3 = addr ?? defAddr;
            Console.WriteLine("Person 3 : "+ person3);

        }
    }
}