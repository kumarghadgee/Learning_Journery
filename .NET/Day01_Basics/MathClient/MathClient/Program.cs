using MathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath obj = new MyMath();
            int res = obj.Add(10, 20);
            Console.WriteLine(res);
            Console.WriteLine(MyMath.Subtract(10, 20));

        }
    }
}
