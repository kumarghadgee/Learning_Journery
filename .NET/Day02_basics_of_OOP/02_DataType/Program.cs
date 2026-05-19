using System.Globalization;

namespace _02_DataType
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            #region
            string str = "123";
            Console.WriteLine($"String : ({str})");
            int num1 = int.Parse(str);
            Console.WriteLine($"Num1 : ({num1})");
            #endregion

            #region
            string str1 = "100";
            int num2 = Convert.ToInt32(str1);
            Console.WriteLine($"Num2 : ({num2})");
            #endregion
        }
        static void Main2(string[] args)
        {
            int num1 = 22, num2 = 7;
            int result = num1 / num2;
            float result2 = (float)(num1 /(double) num2);
            Console.WriteLine($"Result : ({result2})");
        }
        static void Main(string[] args)
        {
            unchecked
            {
                short num1 = 32767;
                num1++;
                Console.WriteLine($"Num1 : ({num1})");
            }
            checked
            {
                short num2 = 32767;
                //num2++;
                Console.WriteLine($"Num2 :({num2})");
            }
        }
    }
}
