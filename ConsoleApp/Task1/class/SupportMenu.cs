using static System.Console;

using static ConsoleApp.Task1.Input;

namespace ConsoleApp.Task1
{
    internal static class SupportMenu
    {
        public static string StartSupportMenu()
        {
            WriteLine("=== Support System ===");

            WriteLine("\n1. What are you calling about?");
            WriteLine("1 - Mobile network issues");
            WriteLine("2 - Internet issues");
            WriteLine("3 - Other");

            int choice1 = GetValidatedInput(1, 3);

            if (choice1 == 1)
            {
                return "Mobile Network Support";
            }
            else if (choice1 == 2)
            {
                return HandleInternetIssues();
            }
            else if (choice1 == 3)
            {
                WriteLine("\nUnfortunately, support for your request is not available right now.");
            }

            return string.Empty;
        }

        private static string HandleInternetIssues()
        {
            WriteLine("\n2. What kind of internet issue?");
            WriteLine("1 - No connection at all");
            WriteLine("2 - Slow speed");
            WriteLine("3 - Wi-Fi problems");

            int choice2 = GetValidatedInput(1, 3);

            if (choice2 == 1)
            {
                return "Internet Emergency Support";
            }
            else if (choice2 == 2)
            {
                return "Internet Technical Support";
            }
            else if (choice2 == 3)
            {
                return HandleWiFiIssues();
            }

            return string.Empty;
        }

        private static string HandleWiFiIssues()
        {
            WriteLine("\n3. What device are you using?");
            WriteLine("1 - Computer");
            WriteLine("2 - Phone");
            WriteLine("3 - Other");

            int choice3 = GetValidatedInput(1, 3);

            if (choice3 == 1 || choice3 == 2)
            {
                return "Wi-Fi Support";
            }
            else if (choice3 == 3)
            {
                WriteLine("\n4. Are you using your own router or ours?");
                WriteLine("1 - My own");
                WriteLine("2 - Company router");

                int choice4 = GetValidatedInput(1, 2);

                if (choice4 == 2)
                {
                    return "Internal Network Support";
                }
            }

            return string.Empty;
        }
    }
}

