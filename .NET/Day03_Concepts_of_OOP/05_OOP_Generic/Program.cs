using System.Globalization;

namespace _05_OOP_Generic
{
    internal class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; 
            a = b; 
            b = temp;
        }
        static void Main1(string[] args)
        {
            int n1 = 12, n2 = 24;
            Swap<int> (ref n1, ref n1);
            Console.WriteLine($"Swapping Done = n1 : {n1} , n2 : {n2}");

            double n3 = 24.24, n4 = 36.36;
            Swap<double>(ref n3, ref n4);
            Console.WriteLine($"Swapping Done = n3 : {n3} , n4 : {n4}");

            string n5 = "DAC", n6 = "DMC";
            Swap<string>(ref n5, ref n6);
            Console.WriteLine($"Swapping Done = n5 : {n5} , n6 : {n6}");

        }

        class Util
        {
            public void Swap<T>( ref T a, ref T b )
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
        static void Main2(string[] args)
        {
            Util util = new Util();
            int n1 = 20, n2 = 10;
            util.Swap<int>(ref n1, ref n2);
            Console.WriteLine($"Swapping Done : n1 : {n1}, n2 : {n2}");
        }

        class Emp : IComparable<Emp>
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public double Salary { get; set; }

            public int CompareTo(Emp other)
            {
                int diff = this.Id - other.Id;
                return diff;
            }

            public override bool Equals(object obj)
            {
                if (obj is Emp)
                {
                    Emp other = (Emp)obj;
                    return this.Id == other.Id;
                }
                return false;
            }

            public override string ToString()
            {
                return $"Id = {Id}, Name = {Name}, Salary = {Salary}";
            }
        }
        class EmpNameComparer : IComparer<Emp>
        { 
            public int Compare(Emp x,Emp y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
        class EmpSalaryComparer : IComparer<Emp>
        {
            public int Compare(Emp x, Emp y)
            {
                return (int)(x.Salary-(y.Salary));
            }
        }
        static void Main3(string[] args)
        {
            Emp[] arr = new Emp[5]
            {
                new Emp{Id = 2,Name = "John", Salary = 1200.0},
                new Emp{Id = 5,Name = "Stephen", Salary = 1250.0},
                new Emp{Id = 3,Name = "Michael", Salary = 13400.0},
                new Emp{Id = 1,Name = "Kobe", Salary = 12050.0},
                new Emp{Id = 4,Name = "Zaltan", Salary = 12340.0}
            };
            Array.Sort(arr);
            Console.WriteLine("Sorted By Id");
            foreach(Emp e in arr)
            {
                Console.WriteLine(e);
            }

            Array.Sort(arr, new EmpNameComparer());
            Console.WriteLine("Sorted by Name");
            foreach(Emp e in arr)
            {
                Console.WriteLine(e);
            }

            Array.Sort(arr, new EmpSalaryComparer());
            Console.WriteLine("Sorted by Salary");
            foreach(Emp e in arr)
            {
                Console.WriteLine(e);
            }
        }

        public static T GetMax<T>(T a,T b) where T : IComparable<T>
        {
            IComparable<T> ac = a;
            if (ac.CompareTo(b) > 0)
                return a;
            return b;
        }
        static void Main4(string[] args)
        {
            string s1 = "ABC";
            string s2 = "XYZ";
            string maxstr = GetMax<string>(s1, s2);
            Console.WriteLine($"Maxstr = {maxstr}");

            Emp e1 = new Emp { Id = 1, Name = "Kumar" , Salary = 9000000.00};
            Emp e2 = new Emp { Id = 2, Name = "Gaurav", Salary = 8900000.00 };
            Emp maxobj = GetMax<Emp>(e1, e2);
            Console.WriteLine($"MaxObj = {maxobj}");
        }

        class Student
        {
            public string Name { get; set; }

            public int Roll { get; set; }

            public double Marks { get; set; }
        }

        public static T CreateObj<T>() where T : class, new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            Student studObj = CreateObj<Student>();
        }
    }
}
