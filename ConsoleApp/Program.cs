using static System.Console;
using ConsoleApp.Subscriptions;
using ConsoleApp.Creators;

string sep = new string('-', 30);

ISubscriptionCreator creator = new WebSite();
Subscription sub = creator.CreateSubscription("Premium");
WriteLine("WebSite Subscipte Premium\n" + sub.Info());

WriteLine(sep);

creator = new MobileApp();
sub = creator.CreateSubscription("Domestic");
WriteLine("MobileApp Sub Domestic\n" + sub.Info());

WriteLine(sep);

creator = new ManagerCall();
sub = creator.CreateSubscription("Educational");
WriteLine("ManagerCall Education\n" + sub.Info());