using System.Runtime.Intrinsics.Arm;

namespace _6_Inheritance
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
        public Person()
        {
            this.Name = "";
            this.Age = 0;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age}");
        }
    }

    class Employee : Person
    {
        public int ID
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }

        public Employee()
        {
            this.ID = 0;
            this.Salary = 0.0;
        }

        public  Employee(string name, int age ,int id, double salary) : base(name, age)
        {
            this.ID = id;
            this.Salary=salary;
        }

        public void DisplayEmployee()
        {
            base.DisplayPerson();
            Console.WriteLine($"ID : {ID}, Salary : {Salary}");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Person p = new Person() { Name = "Kumar", Age = 22};
            p.DisplayPerson();

            Employee e = new Employee() { Name = "Kumar", Age = 22, ID = 1, Salary = 1000000.00 };
            e.DisplayEmployee();

            //UPCASTING
            Person p1 = new Employee() { Name = "Kumar", Age = 22, ID = 1, Salary = 1000000.00 };
            p1.DisplayPerson();

            //DOWNCASTING
            Employee e2 = (Employee)p1;
            e2.DisplayEmployee();

        }
        static void Main(string[] args)
        {
            Person p = new Employee() { Name = "Kumar", Age = 22, ID = 1, Salary = 1000000.00 };
            {
                if(p is Employee)
                {
                    Employee e = (Employee)p;
                    e.DisplayEmployee();
                }
                Employee e2 = p as Employee;
                if (e2 != null)
                {
                    e2.DisplayEmployee();
                }
            }
        }


    }
}
