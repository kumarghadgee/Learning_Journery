using System.Globalization;

namespace _01_OOP_Inheritance
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

        public virtual void Display() // by default method is not virtual
        {
            Console.WriteLine($"Name = {Name},Age = {Age}");
        }
    }

    class Student : Person
    {
        public int Rollno
        {
            get;
            set;
        }

        public int Marks
        {
            get;
            set;
        }

        public override void Display() //We have to use override because bydefault it is new.
        {
            base.Display();
            Console.WriteLine($"Roll No. = {Rollno},Marks = {Marks}");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person p = new Person() { Name = "Kumar" , Age =31 };
            p.Display();
            Console.WriteLine("__________________________________________________________");
            Student s = new Student() { Name = "Kumar", Age = 31, Rollno = 01, Marks = 99 };
            s.Display();
            Console.WriteLine("__________________________________________________________");
            Person p1 = new Student() { Name = "Kumar", Age = 31, Rollno = 01, Marks = 99 };
            p1.Display(); //This Object is a main reason of Run-Time Polymorphism
        }
    }
}