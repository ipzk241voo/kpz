namespace ConsoleApp.Task2 
{
    interface ICommandCentre
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
    }
}
