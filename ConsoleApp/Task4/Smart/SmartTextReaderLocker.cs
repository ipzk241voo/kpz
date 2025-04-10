using System.Text.RegularExpressions;
namespace ConsoleApp.Task4.Smart
{
    internal class SmartTextReaderLocker: SmartTextChecker
    {
        private Regex regex;

        public SmartTextReaderLocker(string path, string pattern) : base(path)
        {
            regex = new Regex(pattern);
        }

        public new char[][] ReadText()
        {
            if (!regex.IsMatch(filePath))
            {
                _logger.Error("Access denied!");
                return null;
            }

            return base.ReadText();
        }
    }
}
