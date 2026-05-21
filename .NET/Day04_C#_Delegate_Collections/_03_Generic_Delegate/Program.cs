namespace _03_Generic_Delegate
{
    internal class Program
    {
        delegate void Consumer<T>(T value);
        delegate T Supplier<T>();
        delegate R Function<T, R>(T arg);
        delegate bool Condition<T>(T args);
        static void Main1(string[] args)
        {
            Consumer<string> con = Console.WriteLine;
            con("Hello World, Its my First Generic delegate built");

            Random r = new Random();
            Supplier<int> supp = r.Next;
            Console.WriteLine("Random Number : " + supp());

            Function<string, int> Convert = int.Parse;
            int num = Convert("123");
            Console.WriteLine($"Num : {num}");

            Condition<int> isEven = (n) => n % 2 == 0;
            Console.WriteLine($"isEven(13) : "+ isEven(13));
        }

        static void Main(string[] args)
        {
            Action<string> con = Console.WriteLine;
            con("Hello World!");

            Random r = new Random();
            Func<int> supp = r.Next;
            Console.WriteLine("Random Number : "+supp());

            Func<string, int> Convert = int.Parse;
            int num = Convert("123");
            Console.WriteLine($"Num : {num}");

            Predicate<int> isEven = (n) => n % 2 == 0;
            Console.WriteLine($"isEven(12) : " + isEven(12));
        }
    }
}