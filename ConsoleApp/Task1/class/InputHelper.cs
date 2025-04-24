using static System.Console;
namespace ConsoleApp.Task1
{
    internal static class Input
    {
        public static int GetValidatedInput(int min, int max)
        {
            int choice;
            while (true)
            {
                Write("Enter your choice: ");
                string? input = ReadLine();

                if (int.TryParse(input, out choice) && choice >= min && choice <= max)
                {
                    return choice;
                }

                WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }
        }
    }
}
