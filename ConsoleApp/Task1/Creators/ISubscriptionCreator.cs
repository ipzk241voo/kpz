using ConsoleApp.Task1.Subscriptions;
namespace ConsoleApp.Task1.Creators
{
    internal interface ISubscriptionCreator
    {
        Subscription CreateSubscription(string type);
    }
}
