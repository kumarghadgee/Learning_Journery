using System.Linq.Expressions;
using System.Diagnostics;


namespace _03_Performance
{
    public delegate P MyDeleagte<P, Q>(Q i);

    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create Expression Tree
            Expression<Func<int, bool>> tree = (i) => i > 10;

            //2.Compile Expression Tree
            Func<int, bool> pointer = tree.Compile();

            Stopwatch stop = new Stopwatch();
            stop.Start();
            //3.Execute Expression Tree
            bool result = pointer(20);
            stop.Stop();

            Console.WriteLine(stop.ElapsedTicks);
            Console.WriteLine(result);
        }
    }
}