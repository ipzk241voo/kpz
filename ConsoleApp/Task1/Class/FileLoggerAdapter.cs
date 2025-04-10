namespace ConsoleApp.Task1.Class
{
    internal class FileLoggerAdapter
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter writer)
        {
            fileWriter = writer;
        }

        public void Log(string message)
        {
            fileWriter.WriteLine("[INFO]: " + message);
        }

        public void Error(string message)
        {
            fileWriter.WriteLine("[ERROR]: " + message);
        }

        public void Warn(string message)
        {
            fileWriter.WriteLine("[WARNING]: " + message);
        }
    }
}
