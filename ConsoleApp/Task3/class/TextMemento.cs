namespace ConsoleApp.Task3
{
    internal class TextMemento
{
        public string SavedState { get; }

        public TextMemento(string content)
        {
            SavedState = content;
        }
    }
}
