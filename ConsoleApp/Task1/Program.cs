using ConsoleApp.Task1.Creators;
using ConsoleApp.Task1.Subscriptions;
using static System.Console;

string sep = new string('-', 30);

WriteLine(sep);
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





