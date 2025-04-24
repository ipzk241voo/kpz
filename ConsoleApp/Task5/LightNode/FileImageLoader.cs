using System.IO;
using ConsoleApp.Task5.Interface;

namespace ConsoleApp.Task5.LightNode
{
    internal class FileImageLoader : IImageLoader
    {
        public string LoadImage(string href)
        {
            if (File.Exists(href))
            {
                return Convert.ToBase64String(File.ReadAllBytes(href));
            }
            throw new FileNotFoundException("File not found: " + href);
        }
    }
}