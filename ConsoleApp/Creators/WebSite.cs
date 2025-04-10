using static System.Console;
using ConsoleApp.Subscriptions;

namespace ConsoleApp.Creators
{
    internal class WebSite : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            WriteLine("Creating subscription via Website...");
            return Create(type);
        }

        private Subscription Create(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type.");
                }
        }
    }
}