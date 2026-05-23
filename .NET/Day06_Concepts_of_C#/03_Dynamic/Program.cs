namespace _03_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic num = "123";
            Console.WriteLine("num : "+num);
            Console.WriteLine("Typeof : " + num.GetType());

            num = 1234;
            Console.WriteLine("num : " + num);
            Console.WriteLine("Typeof : " + num.GetType());

            dynamic str = "String";
            Console.WriteLine("String : "+ str);
            Console.WriteLine("TypeOf : " + str.GetType());

            str = 1234;
            Console.WriteLine("Str : "+str);
            Console.WriteLine("Str : " + str.GetType());

            dynamic p = new
            {
                Name = "Kumar",
                Age = 22,
                Address = "SATARA"
            };

            Console.WriteLine("Name : " +p.Name);
            Console.WriteLine("Age : "+p.Age);
            Console.WriteLine("Address : "+p.Address);
        }
    }
}