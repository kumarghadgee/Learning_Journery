namespace _02_WebApplication.Loggers
{
    public class Logger
    {
        private static Logger _logger = new Logger();

        private Logger()
        {
        }

        public static Logger CurrentLogger
        {
            get { return _logger; }
        }

        public void Log(string messageToLog)
        {
            FileStream fileStream = null;
            string filePath = "E:\\.net Prac\\Day12\\Day12Soln\\log.txt";

            if (File.Exists(filePath))
            {
                fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }

            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(string.Format("Logged at: {0} -> {1} ", DateTime.Now.ToString(), messageToLog));

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();

            streamWriter = null;
            fileStream = null;
        }
    }
}
