using ConsoleApp.Task6.Interface;

namespace ConsoleApp.Task6.Elements
{
    internal class BlockquoteElement : IHtmlElement
    {
        private readonly string _content;
        public BlockquoteElement(string content) => _content = content;
        public string Render() => $"<blockquote>{_content}</blockquote>";
    }
}
