using ConsoleApp.Task6.Interface;

namespace ConsoleApp.Task6.Elements
{
    internal class HtmlElementFactory
    {
        public static IHtmlElement CreateHtmlElement(string trimmedLine, string originalLine)
        {
            if (originalLine.StartsWith(" "))
            {
                return new BlockquoteElement(originalLine);
            }
            else if (trimmedLine.Length < 20)
            {
                return new H2Element(originalLine);
            }
            else
            {
                return new H1Element(originalLine);
            }
        }
    }
}
