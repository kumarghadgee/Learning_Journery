using System.Collections;
namespace _04_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Sunbeam DAC";
            Type t1 = s1.GetType();
            Console.WriteLine("s1 GetType : " + t1.FullName);

            Type t = typeof(ArrayList);
            Console.WriteLine("ArrayList Type : "+t.FullName);

            string str = "System.Collections.Generics";
            Type t2 = Type.GetType(str);
            Console.WriteLine("Type of t2 : "+ t2?.FullName);
        }
    }
}