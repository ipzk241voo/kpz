using static System.Console;
using ConsoleApp.Task6.Class;

static async Task Main(string[] args)
{
    string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
    string bookText = await Book.DownloadBookTextAsync(url);
    string htmlContent = Book.ConvertToHtml(bookText);
    WriteLine(htmlContent);
    long memorySize = Book.GetMemorySize(htmlContent);
    WriteLine($"Пам'ять, яку займає HTML верстка: {memorySize} байт");
}

Task task = Main(args);
task.Wait();