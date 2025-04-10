using static System.Console;
using ConsoleApp.Task1.Subscriptions;

namespace ConsoleApp.Task1.Creators
{
    internal class ManagerCall : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            WriteLine("Creating subscription via ManagerCall...");
            return Create(type);
        }

        private Subscription Create(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription { Price = 80, Features = { "HD+", "Music+" } };
                case "Educational":
                    return new EducationalSubscription { Price = 220 };
                case "Premium":
                    return new PremiumSubscription { Price = 330 };
                default:
                    throw new ArgumentException("Invalid subscription type.");
            }
        }
    }
}
