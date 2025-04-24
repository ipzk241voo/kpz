using ConsoleApp.Task5.Interface;

namespace ConsoleApp.Task5.LightNode
{
    internal class NetworkImageLoader : IImageLoader
    {
        public string LoadImage(string href)
        {
            using HttpClient client = new HttpClient();
            var imageBytes = client.GetByteArrayAsync(href).Result;
            return Convert.ToBase64String(imageBytes);
        }
    }
}