namespace _07_PartialClass
{
    partial class Myclass
    {
        int x = 10;
        public partial void Method();
    }

    partial class Myclass
    {
        public void Display()
        {
            this.Method();

            Console.WriteLine("X = "+ x);
        }
        public partial void Method()
        {
            Console.WriteLine("Partial.Method Called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            my.Display();
            my.Method();
        }
    }
}
