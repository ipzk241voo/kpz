using ConsoleApp.Task6.Elements;
using ConsoleApp.Task6.Interface;
using System.Text;

namespace ConsoleApp.Task6.Class
{
    internal static class Book
    {
        public static async Task<string> DownloadBookTextAsync(string url)
        {
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);
        }

        public static string ConvertToHtml(string text)
        {
            StringBuilder htmlOutput = new StringBuilder();
            string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (string.IsNullOrEmpty(trimmedLine))
                {
                    continue;
                }

                IHtmlElement htmlElement = HtmlElementFactory.CreateHtmlElement(trimmedLine, line);
                htmlOutput.AppendLine(htmlElement.Render());
            }

            return htmlOutput.ToString();
        }

        public static long GetMemorySize(string content)
        {
            return Encoding.UTF8.GetByteCount(content);
        }
    }
}
