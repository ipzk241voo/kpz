namespace ConsoleApp.Task2.Device
{
    internal class Smartphone: IDevice
    {
        private string Brand;
        public Smartphone(string Brand) => this.Brand = Brand;
        public string Info() => $"Smartphone of brand {Brand}";
    }
}
