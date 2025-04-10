using ConsoleApp.Task2.Device;

namespace ConsoleApp.Task2.Factory
{
    internal interface ITechFactory
    {
        IDevice CreateDevice(string name);
    }
}
