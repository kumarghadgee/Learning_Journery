using System.Collections;

namespace _05_Exception
{
    public class MyStack
    {
        private int[] _arr;
        private int _top = -1;

        public MyStack(int capacity) => _arr = new int[capacity];

        public int Capacity => _arr.Length;
        public int Count => _top + 1;

        public void Push(int value) => _arr[++_top] = value;

        public int Pop() => _arr[_top--];

        public int Peek() => _arr[_top];

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > _top)
                    throw new InvalidIndexException(index);
                return _arr[index];
            }
            set
            {
                if (index < 0 || index > _top)
                    throw new InvalidIndexException(index);
                _arr[index] = value;
            }
        }

        //public IEnumerator GetEnumerator()
        //{
        //    for (int i = 0; i <= _top; i++)
        //        yeild return _arr[i];
        //}
    }

    public class InvalidIndexException : ApplicationException
    {
        private int _index;

        public InvalidIndexException(int index) : base($"Invalid index : {index}")
        {
            this._index = index;
        }

        public int Index => _index;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            Console.WriteLine("Popped Element: " + s.Pop());
            int index = 2;
            s[index] = 30;
        }
    }
}