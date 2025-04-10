namespace ConsoleApp.Task1.Subscriptions
{
    internal class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            Price = 1020;
            MinPeriod = 3;
            Channels = new List<string> { "TV", "ICTV", "D2", "TV+", "HD-Rezka", "ICTV+", "Premium Game", "4Code" };
            Features = new List<string> { "4K HD", "Watching new movies", "Access to new music" };
        }
    }
}
