using static System.Console;

namespace ConsoleApp.Task5.LightNode
{
    public class ClickEventListener : IEventListener
    {
        public void HandleEvent(string eventType)
        {
            WriteLine($"Event '{eventType}' triggered!");
        }
    }
}