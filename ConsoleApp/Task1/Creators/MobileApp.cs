using static System.Console;
using ConsoleApp.Task1.Subscriptions;

namespace ConsoleApp.Task1.Creators
{
    internal class MobileApp : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            WriteLine("Creating subscription via MobileApp...");
            return Create(type);
        }

        private Subscription Create(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription { Price = 200 } ;
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type.");
            }
        }
    }
}
