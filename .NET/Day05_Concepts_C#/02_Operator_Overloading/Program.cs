using System.Reflection.Metadata.Ecma335;

namespace _02_Operator_Overloading
{
    class Vector
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Vector operator+(Vector arg1, Vector arg2)
        {
            Vector res = new Vector();
            res.X = arg1.X + arg2.X;
            res.Y = arg1.Y + arg2.Y;
            res.Z = arg1.Z + arg2.Z;

            return res;
        }

        public static bool operator==(Vector arg1,Vector arg2)
        {
            return arg1.X == arg2.X && arg1.Y == arg2.Y && arg1.Z == arg2.Z;
        }
        public static bool operator!=(Vector arg1, Vector arg2)
        {
            return !(arg1.X == arg2.X);
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector() { X = 1, Y = 2, Z = 3 };
            Vector v2 = new Vector() { X = 1, Y = 2, Z = 3 };

            Vector v3 = v1 + v2;
            Console.WriteLine(v3);

            Console.WriteLine("Equality : " + (v1 == v2));
        }
    }
}
