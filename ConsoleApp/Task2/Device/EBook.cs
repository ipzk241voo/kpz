namespace ConsoleApp.Task2.Device
{
    internal class EBook: IDevice
    {
        private string Brand;
        public EBook(string Brand) => this.Brand = Brand;
        public string Info() => $"EBook of brand {Brand}";
    }
}
