namespace _02_DemoDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkFactory factory = new DrinkFactory();

            Console.WriteLine("Whats the temp?");
            int temp = Convert.ToInt32(Console.ReadLine());

            IDrink drink = factory.GetDrink(temp);
            //string mydrink =  drink.GetDrink();
            //Console.WriteLine(mydrink);

            Festival festival = new Festival("Xmas");
            festival.Celebrate(drink);

            Console.ReadLine();
        }

        public class Festival
        {
            private string nameOfFestival;
            public Festival(string nameOfFestival)
            {
                this.nameOfFestival = nameOfFestival;
            }
            public void Celebrate(IDrink drink)
            {
                Console.WriteLine($"Celebrating {nameOfFestival} with {drink.GetDrink()}");
            }
        }

        public interface IDrink
        {
            string GetDrink();
        }

        public class ColdDrink : IDrink
        {
            public string GetDrink()
            {
                return "Coke";
            }
        }

        public class HotDrink : IDrink
        {
            public string GetDrink()
            {
                return "Tea";
            }
        }

        public class DrinkFactory // Inversion Of Control i.e. IOC
        {
            public IDrink GetDrink(int temp)
            {
                if (temp > 40)
                {
                    return new ColdDrink();
                }
                else
                {
                    return new HotDrink();
                }
            }
        }
    }
}