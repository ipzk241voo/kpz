namespace ConsoleApp.Task1.Subscriptions
{
    internal class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            Price = 460.20;
            MinPeriod = 2;
            Channels = new List<string> { "TV+", "HD-Rezka", "ICTV+" };
            Features = new List<string> { "2K HD", "Watching new movies" };
        }
    }
}