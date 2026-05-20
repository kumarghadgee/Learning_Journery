namespace _02_OOP_Inheritance
{
    abstract class Emp
    {
        public int Id { get; set; }

        public double Salary {  get; set; }

        public virtual double CalcIncome()
        {
            return Salary;
        }

        public abstract void DoWork();
    }

    class Labor : Emp
    {
        private int _hours;
        private double _rate;

        public int Hours
        {
            get { return _hours; }
            set
            {
                _hours = value;
                Salary = Hours * _rate;
            }
        }
        public double Rate
        {
            get { return _rate; }
            set
            {
                _rate = value;
                Salary = Hours * Rate;
            }
        }

        public override void DoWork()
        {
            Console.WriteLine("Labor : DoWork");
        }
    }

    class Manager : Emp
    {
        public int Bonus
        {
            get;
            set;
        }

        public sealed override double CalcIncome()
        {
            return Salary + Bonus;
        }

        public override void DoWork()
        {
            Console.WriteLine($"Manager : DoWork");
        }
    }

    class SalesManager : Manager
    {
        public override void DoWork()
        {
            Console.WriteLine($"SalesManager : DoWork");
        }
    }

    class HRManager : Manager
    {
        //DoWork -- Not Required
    }

    class SalesMan : Emp
    {
        public double Commission
        {
            get;
            set;
        }
        public override double CalcIncome()
        {
            return Salary + Commission;
        }

        public override void DoWork()
        {
            Console.WriteLine($"SalesMan : DoWork");
        }
    }
    sealed class Clerk : Emp
    {
        public override void DoWork()
        {
            Console.WriteLine($"Clerk : DoWork");
        }
    }

    static class EmpUtil
    {
        public static double CalcTotalIncome( Emp[] emp)
        {
            double total = 0;
            foreach (Emp e in emp)
            {
                total= total+e.CalcIncome();
            }
            return total;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp[] emps = new Emp[6]
            {
                    new Manager() { Id=1, Salary=10000.0, Bonus=2000},
                    new Clerk() { Id=2, Salary=3000.0},
                    new SalesMan() { Id=3, Salary=4000.0, Commission=1000.0},
                    new HRManager() { Id=4, Salary=9000.0, Bonus=1000},
                    new Labor() { Id=5, Hours=100, Rate=20.0},
                    new SalesManager() { Id=4, Salary=10000.0, Bonus=1000}
            };
            double total = EmpUtil.CalcTotalIncome( emps );
            Console.WriteLine($"Total = {total}");

        }
    }
}