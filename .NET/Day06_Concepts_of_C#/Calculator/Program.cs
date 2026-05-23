namespace Calculator
{
    static class Calculator
    {
        public static void AcceptRecord(out int num1,out int num2)
        {
            Console.Write("Enter Your First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Second Number : ");
            num2 = int.Parse(Console.ReadLine());
        }

        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Mul(int num1,int num2)
        {
            return num1 * num2;
        }

        public static int Div(int num1,int num2)
        {
            return num1 / num2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("0.Exit.");
                Console.WriteLine("1.Addition.");
                Console.WriteLine("2.Subtraction.");
                Console.WriteLine("3.Multiplication.");
                Console.WriteLine("4.Division.");
                Console.Write("Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int number1, number2;
                        Calculator.AcceptRecord(out number1, out number2);
                        int result = Calculator.Add(number1, number2);
                        Console.WriteLine($"Addition of Two Numbers is {result}");
                        break;

                    case 2:
                        int number3, number4;
                        Calculator.AcceptRecord(out number3, out number4);
                        int result1 = Calculator.Sub(number3, number4);
                        Console.WriteLine($"Subtraction of Two Numbers is {result1}");
                        break;

                    case 3:
                        int number5, number6;
                        Calculator.AcceptRecord(out number5, out number6);
                        int result2 = Calculator.Mul(number5, number6);
                        Console.WriteLine($"Multiplication of Two Numbers is {result2}");
                        break;

                    case 4:
                        int number7, number8;
                        Calculator.AcceptRecord(out number7, out number8);
                        int result3 = Calculator.Mul(number7, number8);
                        Console.WriteLine($"Multiplication of Two Numbers is {result3}");
                        break;

                    case 0:
                        Console.WriteLine("You are Exiting the Calculator..... ThankYou :)");
                        break;

                } 
            } while (choice != 0);

        }
    }
}