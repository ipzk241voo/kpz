using ConsoleApp.Task2.Device;

namespace ConsoleApp.Task2.Factory
{
    internal abstract class FactoryClass : ITechFactory
    {
        public string Brend { get; set; }
        public FactoryClass(string Brend)
        {
            this.Brend = Brend;
        }

        public IDevice CreateDevice(string device)
        {
            switch (device)
            {
                case "Laptop":
                    return new Laptop(Brend);
                case "Netbook":
                    return new Netbook(Brend);
                case "EBook":
                    return new EBook(Brend);
                case "SmartPhone":
                    return new Smartphone(Brend);
                default:
                    throw new ArgumentException("Invalid device.");
            }
        }
    }
}
