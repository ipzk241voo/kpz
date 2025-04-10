namespace ConsoleApp.Task1.Subscriptions
{
    internal class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            Price = 100.50;
            MinPeriod = 2;
            Channels = new List<string> { "TV", "ICTV", "D2" };
        }
    }
}
