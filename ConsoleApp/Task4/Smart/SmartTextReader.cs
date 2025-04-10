namespace ConsoleApp.Task4.Smart
{
    internal class SmartTextReader
    {
        public string filePath;

        public SmartTextReader(string path)
        {
            filePath = path;
        }

        public char[][] ReadText()
        {
            string[] lines = File.ReadAllLines(filePath);
            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}
