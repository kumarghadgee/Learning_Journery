using System.Security.Cryptography.X509Certificates;

namespace _06_Delegate
{
    internal class Program
    {
        delegate void MathOp(int x, int y);

        class MyMath
        {
            public void Subtract(int x, int y) 
            {
                Console.WriteLine($"Subtract : {x} - {y} = {x - y}");
            }

        }
        public static void Sum(int x, int y)
        {
            Console.WriteLine($"Sum : {x} + {y} = {x + y}");
        }
        static void Main1(string[] args)
        {
            MathOp ptr1;
            ptr1 = new MathOp(Program.Sum);
            ptr1(40, 10);

            MyMath Math = new MyMath();
            MathOp ptr2 = new MathOp(Math.Subtract);
            ptr2(40, 10);

            void Multiply(int x, int y)
            {
                Console.WriteLine($"Multiply : {x} * {y} = {x * y}");
            }

            MathOp ptr3 = new MathOp(Multiply);
            ptr3(10,30);

            void Divide(int x, int y)
            {
                Console.WriteLine($"Divide : {x} / {y} = {x / y}");
            }
            MathOp ptr4 = Divide;
            ptr4(40, 10);

            MathOp ptr5 = delegate (int x, int y)
            {
                Console.WriteLine($"Modulus : {x} % {y} = {x % y}");
            };
            ptr5(100, 10);

            MathOp ptr6 = (x, y) => Console.WriteLine($"Lambda : {x} * {y} = {x * y}");
            ptr6(56, 7);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            MathOp ptr = ptr1;
            ptr += ptr2;
            ptr += ptr3;
            ptr += ptr4;
            ptr += ptr5;
            ptr += ptr6;
            ptr(20, 10);
        }

        delegate int MathRetOp(int x, int y);

        static void Main(string[] args)
        {
            MathRetOp pt = (a , b) => (a + b);
            pt += (a , b) => (a * b);
            pt += (a , b) => (a / b);
            pt += (a , b) => (a - b);
            pt += (a , b) => (a % b);

            //int res = ptr(40, 10);
            //Console.WriteLine($"res = {res}");
            foreach(MathRetOp p in pt.GetInvocationList())
            {
                int r = p(30, 10);
                Console.WriteLine($"result = {r}");
            }
        }
    }
}