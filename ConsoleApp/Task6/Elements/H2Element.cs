using ConsoleApp.Task6.Interface;

namespace ConsoleApp.Task6.Elements
{
    internal class H2Element: IHtmlElement
    {
        private readonly string _content;
        public H2Element(string content) => _content = content;
        public string Render() => $"<h2>{_content}</h2>";
    }
}
