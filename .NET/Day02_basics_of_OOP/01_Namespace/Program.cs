global using TreeSpace;

namespace ListSpace
{
    class Node
    {
        public void Add(int data)
        {
            Console.WriteLine($"Node.Add({data})");
        }
    }
}

namespace ListSpace
{
    class List
    {
        public void Add(int data)
        {
            Console.WriteLine($"List.Add({data})");
        }
    }
}

namespace TreeSpace
{
    class Tree
    {
        public void Add(int data)
        {
            Console.WriteLine($"Tree.Add({data})");
        }
    }
}

namespace _01_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListSpace.Node n1 = new ListSpace.Node();
            n1.Add(10);

            ListSpace.List l1 = new ListSpace.List();
            l1.Add(30);

            TreeSpace.Tree t2 = new TreeSpace.Tree();
            t2.Add(50);

            Tree t3 = new TreeSpace.Tree();
            t3.Add(100);
        }
    }
}
