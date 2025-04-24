using static System.Console;
using static ConsoleApp.Task1.SupportMenu;

string handler;

do
{
    handler = StartSupportMenu();
    if (handler == string.Empty)
    {
        WriteLine("\nCould not determine support level. Please try again.\n");
    }
}
while (handler == string.Empty);
WriteLine($"\nYou have been connected to: {handler}");
WriteLine("\nPress any key to exit...");
ReadKey();