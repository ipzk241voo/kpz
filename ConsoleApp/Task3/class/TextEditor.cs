using ConsoleApp.Task3;

namespace ConsoleApp.Task
{
    internal class TextEditor
    {
        private readonly TextDocument _document = new();
        private readonly Stack<string> _history = new();

        public void Write(string text)
        {
            Save();
            _document.Content += text;
        }

        public void Show() => _document.Show();

        public void Undo()
        {
            if (_history.TryPop(out var previousState))
            {
                _document.Content = previousState;
            }
        }

        private void Save() => _history.Push(_document.Content);
    }
}
