using System.ComponentModel;

namespace _06_Generic_Collections
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Remove(10);
            list.IndexOf(3);

            //foreach(int n in list)
            //{
            //    Console.WriteLine(n);
            //}
            IEnumerator<int> en = list.GetEnumerator();
            while (en.MoveNext())
            {
                int ele = en.Current;
                Console.WriteLine(ele);
            }
        }

        static void Main2(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            stk.Push(40);

            stk.Peek();
            IEnumerator<int> en = stk.GetEnumerator();
            while(stk.Count > 0)
            {
                int ele = stk.Pop();
                Console.WriteLine(ele);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("Kumar", "207");
            map.Add("Aniket", "207");
            map.Add("Atharv", "207");
            map.Add("Sanjay", "204");
            map.Add("Vishwajeet", "204");

            foreach(KeyValuePair<string,string> m in map)
            {
                Console.WriteLine(m);
            }
        }

    }
}