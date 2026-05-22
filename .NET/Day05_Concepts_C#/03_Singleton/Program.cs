using System.Globalization;

namespace _03_Singleton
{
    class FileLogger
    {
        string _path = "E:\\.net Prac\\Day05\\Day05_Soln\\logFile.txt";

        public void Log(string msg)
        {
            string m = DateTime.Now.ToString() + ":" + msg + "\n";
            File.AppendAllText(_path, m);
        }

        private FileLogger()
        {

        }

        public static readonly FileLogger instance;

        static FileLogger()
        {
            instance = new FileLogger();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger.instance.Log("Hello World!");
            FileLogger.instance.Log("Lecture Time");
            FileLogger.instance.Log("Its My Breakfast Time!");
            FileLogger.instance.Log("Lecture");
            FileLogger.instance.Log("Lunch Time!");
            FileLogger.instance.Log("Lab Time");
            FileLogger.instance.Log("Self-Study Time");

        }
    }
}