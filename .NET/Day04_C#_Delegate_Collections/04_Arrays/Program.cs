using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace _04_Arrays
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            string[] arr2 = new string[5] { "Kumar","Gaurav","Sai","Sairaj","Ghadge"};
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
            foreach(string s in arr2)
            {
                Console.WriteLine(s);
            }

            int[] arr3 = { 2, 4, 5, 6, 7 };
            foreach(int n in arr3)
            {
                Console.WriteLine(n);
            }
            for(int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine($"Array : {arr3[i]}");
            }

        }
        static void Main2(string[] args)
        {
            string[] s = new string[20];
            foreach(string str in s)
            {
                Console.WriteLine(str);
            }
        }

        static void Main3(string[] args)
        {
            int[,] mat = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            foreach(int n in mat)
            {
                Console.WriteLine(n);
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.Write(mat[i, j]+ "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main4(string[] args)
        {
            int[][] mat = new int[3][];
            mat[0] = new int[] { 1, 2, 3 };
            mat[1] = new int[] { 4, 5 };
            mat[2] = new int[] { 6 };

            for(int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write(mat[i][j] +"\t");
                }
                Console.WriteLine();
            }
        }

        static void Main5(string[] args)
        {
            int AddAll(params int[] arr)
            {
                int total = 0;
                foreach (int n in arr)
                {
                    total = total + n;
                }
                return total;
            }
            Console.WriteLine("Addition of 2 Numbers : " +AddAll(20,10));
            Console.WriteLine("Addition of 3 Numbers : " + AddAll(30,20, 10));
        }
        static void Main(String[] args)
        {
            object[] arr = { 10, 10.1, "DAC", true, DateTime.Now };
            foreach(object a in arr)
            {
                if(a is string)
                {
                    string s = (string)a;
                    Console.WriteLine("lower : " + s.ToLower());
                } 
                else if(a is int){
                    int num = (int)a;
                    Console.WriteLine("Square : "+ num * num);
                }
                else
                {
                    Console.WriteLine("Ele : " + a);
                }
            }
        }
    }
}