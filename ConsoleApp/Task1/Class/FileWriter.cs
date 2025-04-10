using System.IO;
namespace ConsoleApp.Task1.Class
{
    internal class FileWriter
    {
        private string FilePath;

        public FileWriter(string path)
        {
            FilePath = path;
        }

        public void Write(string message)
        {
            File.AppendAllText(FilePath, message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(FilePath, message + "\n");
        }

    }
}
