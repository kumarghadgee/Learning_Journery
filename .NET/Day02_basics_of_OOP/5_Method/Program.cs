namespace _5_Method
{
    class MyInt
    {
        public int Num
        {
            get;
            set;
        }
    }
    internal class Program
    {
        public static void swap1(int x, int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine($"Inside swap method x = {x} and y = {y}");
        }
        public static void swap2(MyInt x, MyInt y)
        {
            int t = x.Num;
            x.Num = y.Num;
            y.Num = t;
            Console.WriteLine($"Inside swap method x = {x.Num} and y = {y.Num}");
        }

        public static void swap3(ref int x ,ref int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine($"Inside swap method x = {x} and y = {y}");
        }
        static void Main1(string[] args)
        {
            #region PASS BY VALUE
            int n1 = 10, n2 = 20;
            Console.WriteLine($"Before swap method n1 = {n1} and n2 = {n2}");
            swap1(n1, n2);
            Console.WriteLine($"After swap method n1 = {n1} and n2 = {n2}");
            #endregion

            #region PASS BY REFERENCE
            MyInt m1 = new MyInt() { Num = 30 };
            MyInt m2 = new MyInt() { Num = 40 };
            Console.WriteLine($"Before swap method m1 = {m1.Num} and m2 = {m2.Num}");
            swap2(m1, m2);
            Console.WriteLine($"After swap method m1 = {m1.Num} and m2 = {m2.Num}");
            #endregion

            #region Ref Method
            int n5 = 50, n6 = 60;
            Console.WriteLine($"Before swap method n5 = {n5} and n6 = {n6}");
            swap3(ref n5, ref n6);
            Console.WriteLine($"After swap method n5 = {n5} and n6 = {n6}");

            #endregion
        }
        static void Main(string[] args)
        {
            void PrintInfo(string name, int age, string address = "AnyWhere", string email = "Unknown")
            {
                Console.WriteLine($"name = {name} , age = {age} , addr = {address} , email = {email}");
            }
            //calling PrintInfo() using positional arg -- as per arg seq
            PrintInfo("Nilesh", 31, "Pune", "Nilesh@gmail");

            // calling PrintInfo() using named arg -
            // arg value associated with name of the arg 
            // arg can be passed in any sequence
            PrintInfo(name: "Nilesh", age: 31, email: "Nilesh@gmail", address: "Pune");

            // first two args are passed positional -- by seq
            // next two args are passed by name
            PrintInfo("Nilesh", 31, email: "nilesh@gmail", address: "Pune"); 

            // calling PrintInfo() using default args
            // the not passed args will get their default values
            // all default args must be at the end.
            PrintInfo("Nilesh", 31);
        }
    }
}
