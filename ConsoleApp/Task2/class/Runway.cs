using static System.Console;

namespace ConsoleApp.Task2
{
    internal class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft { get; set; }

        public void HighLightRed() => WriteLine($"Runway {Id} is busy!");
        public void HighLightGreen() => WriteLine($"Runway {Id} is free!");
        public bool IsAvailable => IsBusyWithAircraft == null;
    }
}
