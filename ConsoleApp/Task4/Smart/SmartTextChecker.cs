using ConsoleApp.Task1;
namespace ConsoleApp.Task4.Smart
{
    internal class SmartTextChecker: SmartTextReader
    {
        public SmartTextChecker(string path) : base(path) { }

        public Logger _logger = new Logger();

        public new char[][] ReadText()
        {

            _logger.Log(filePath);

            try
            {
                _logger.Log($"Opening file: {filePath}");

                char[][] content = base.ReadText();

                int totalLines = content.Length;
                int totalChars = 0;

                foreach (var line in content)
                {
                    totalChars += line.Length;
                }

                _logger.Log($"File opened successfully. Lines: {totalLines}, Characters: {totalChars}");
                _logger.Log("Reading file...");
                return content;
            }
            catch (Exception ex)
            {
                _logger.Error($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                _logger.Log($"File {filePath} closed.");
            }
        }
    }
}
