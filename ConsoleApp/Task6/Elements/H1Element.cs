using ConsoleApp.Task6.Interface;

namespace ConsoleApp.Task6.Elements
{
    internal class H1Element: IHtmlElement
    {
        private readonly string _content;
        public H1Element(string content) => _content = content;
        public string Render() => $"<h1>{_content}</h1>";
    }
}
