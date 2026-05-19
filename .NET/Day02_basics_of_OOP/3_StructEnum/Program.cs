using System.Runtime.InteropServices;

namespace _3_StructEnum
{
    struct Point
    {
        int _x;
        int _y;

        public Point()
        {
            Console.WriteLine($"Parameterless Constructor is Called....");
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public void DisplayPoint()
        {
            Console.WriteLine($" x  = {X} , y = {Y}");
        }
    }

    enum WEEKDAYS
    {
        SUNDAY,MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY,SATURDAY
    }

    enum Menu
    {
        EXIT, ADD, MUL, SUB, DIV
    }
    internal class Program2
    {
        static void Main1(string[] args)
        {
            Point pt = new Point();
            pt.X = 10;
            pt.Y = 20;
            Console.WriteLine($"Point = {pt.X} and {pt.Y}");

            //Point pt;
            //pt.DisplayPoint();

            Point pt2 = new Point() {X =10 , Y= 20};
            Console.WriteLine($"X = ({pt2.X}) , Y = ({pt2.Y}) ");
        }
        static void Main(string[] args)
        {
            #region
            WEEKDAYS w = new WEEKDAYS();
            Console.WriteLine($"w = {w} , ordinal = {(int)w}");

            WEEKDAYS w1 = (WEEKDAYS)1;
            Console.WriteLine($"w1 = {w1} ,ordinal = {(int)w1}");
            #endregion

            Array menuvalues = Enum.GetValues(typeof(Menu));
            foreach (Menu m in menuvalues)
            {
                Console.WriteLine((int)m + "." + m);
            }
            Console.WriteLine("Enter the choice ");
            //int choice = int.Parse(Console.ReadLine());
            int choice = Convert.ToInt32(Console.ReadLine());
            Menu option = (Menu)choice;

            switch (option)
            {
                case Menu.ADD:
                    Console.WriteLine("ADD");
                    break;
                case Menu.SUB:
                    Console.WriteLine("SUB");
                    break;
            }
        }
    }
}
