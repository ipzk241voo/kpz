using static System.Console;
using ConsoleApp.Task3.Interface;

namespace ConsoleApp.Task3.Render
{
    internal class RasterRenderer: IRenderer
    {
        public void Render(string shapeName)
        {
            WriteLine($"Drawing {shapeName} as pixels");
        }
    }
}
