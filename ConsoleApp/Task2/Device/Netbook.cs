namespace ConsoleApp.Task2.Device
{
    internal class Netbook: IDevice
    {
        private string Brand;
        public Netbook(string Brand) => this.Brand = Brand;
        public string Info() => $"Netbook of brand {Brand}";
    }
}
