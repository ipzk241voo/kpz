using static System.Console;

namespace ConsoleApp.Task3
{
    internal class TextDocument
    {
        public string Content { get; set; } = string.Empty;

        public void Show() => WriteLine($"Document content: {Content}");
    }
}
