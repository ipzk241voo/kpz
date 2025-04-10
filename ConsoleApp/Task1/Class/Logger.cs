using static System.Console;

namespace ConsoleApp.Task1
{
    internal class Logger
    {
        public void Log(string message)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("[INFO]: " + message);
            ResetColor();
        }

        public void Error(string message)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("[ERROR]: " + message);
            ResetColor();
        }

        public void Warn(string message)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("[WARNING]: " + message);
            ResetColor();
        }
    }
}
