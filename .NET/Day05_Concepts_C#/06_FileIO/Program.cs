namespace _06_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Filepath = "E:/.net Prac/Day05/Day05_Soln/fileIo.txt";

            Console.WriteLine("Enter the data...");
            string line = (Console.ReadLine());
            File.AppendAllText(Filepath,line);

            string text = File.ReadAllText(Filepath);
            Console.WriteLine(text);
        }
    }
}
