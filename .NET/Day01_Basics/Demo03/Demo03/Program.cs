using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Person
    {
        private String name;
        private String addr;
        private int age;

        public Person() : this("","",0)
        {

        }
        public Person(String name, String addr, int age)
        {
            this.name = name;
            this.addr = addr;
            this.age = age;
        }

        public String Name
        {
            get;
            set;
        }

        public String Addr
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public void AcceptRecord()
        {
            Console.WriteLine("Enter the Name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            this.addr = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            string agestr = Console.ReadLine();
            this.age = int.Parse(agestr);
        }

        public void DisplayRecord()
        {
            Console.WriteLine("Name : {0}, Address : {1}, Age : {2}",this.name,this.addr,this.age);
        }

        ~Person()
        {
            Console.WriteLine("Person Died");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.AcceptRecord();
            p.DisplayRecord();
        }
    }
}
