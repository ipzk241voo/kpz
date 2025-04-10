using ConsoleApp.Task6.Interface;

namespace ConsoleApp.Task6.Elements
{
    internal class PElement : IHtmlElement
    {
        private readonly string _content;
        public PElement(string content) => _content = content;
        public string Render() => $"<p>{_content}</p>";
    }

}
