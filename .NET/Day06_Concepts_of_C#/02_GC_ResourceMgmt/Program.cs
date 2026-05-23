namespace _02_GC_ResourceMgmt
{
    public class Myclass : IDisposable
    {
        public Myclass()
        {
            Console.WriteLine("Constructor Is Called....");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose() Method....");
        }

        ~Myclass()
        {
            Console.WriteLine("Desctructor is called....");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Myclass my = new Myclass();
            my.Dispose();
            my = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        static void Main(string[] args)
        {
            try
            {
                using(Myclass my = new Myclass())
                {

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}