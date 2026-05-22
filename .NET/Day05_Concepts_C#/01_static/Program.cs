using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _01_static
{
    sealed public class Myclass
    {

        public const double PI = 3.14;

        public static readonly int num;

        static Myclass()
        {
            num = 123;
        }

        public static void Display()
        {
            Console.WriteLine($"Num : {num}");
        }
    }
    
    static class MyclassExtension
    {
        public static void ExtDisplay(this Myclass m)
        {
            Console.WriteLine("MyclassExtension : ExtDisplay" + m);
        }
    }
  
    static class StringExtension
    {
        public static string SwapCase(this string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char ch in s)
            {
                if (char.IsLower(ch))
                {
                    sb.Append(char.ToUpper(ch));
                }
                else if (char.IsUpper(ch))
                {
                    sb.Append(char.ToLower(ch));
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Myclass.Display();
            Myclass obj = new Myclass();
            obj.ExtDisplay();
        }

        static void Main(string[] args)
        {
            string str = "Sunbeam";
            string s = str.SwapCase();
            Console.WriteLine(s);
        }
    }
}