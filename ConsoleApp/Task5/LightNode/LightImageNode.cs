namespace ConsoleApp.Task5.LightNode
{
    internal class LightImageNode : LightNode
    {
        private readonly string _href;
        private readonly IImageLoader _imageLoader;

        public LightImageNode(string href, IImageLoader imageLoader)
        {
            _href = href;
            _imageLoader = imageLoader;
        }

        public override string OuterHTML()
        {
            string base64Image = _imageLoader.LoadImage(_href);
            return $"<img src=\"data:image;base64,{base64Image}\" />";
        }

        public override string InnerHTML()
        {
            return string.Empty;
        }
    }
}