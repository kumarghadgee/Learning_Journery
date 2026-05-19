namespace _4_Boxing
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int num1 = 123;
            object obj = num1;  //BOXING --> Value type to the Reference type
            Console.WriteLine(obj);
            int num2 = (int)obj; //UNBOXING --> Converting Reference to Value type
            Console.WriteLine(num2);
        }
    }
}