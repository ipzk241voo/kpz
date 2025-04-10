namespace ConsoleApp.Creators
{
    internal interface ISubscriptionCreator
    {
        Subscriptions.Subscription CreateSubscription(string type);
    }
}
