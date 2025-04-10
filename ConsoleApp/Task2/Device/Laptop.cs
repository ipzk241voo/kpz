namespace ConsoleApp.Task2.Device
{
    internal class Laptop: IDevice
    {
        private string Brand;
        public Laptop(string Brand) => this.Brand = Brand;
        public string Info() => $"Laptop of brand {Brand}";
    }
}
