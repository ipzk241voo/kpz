namespace ConsoleApp.Task2
{
    internal class Aircraft
    {
         
        public string Name { get; }
        public bool IsTakingOff { get; set; }

        private readonly ICommandCentre _commandCentre;

        public Aircraft(string name, ICommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre;
        }

        public void Land()
        {
            _commandCentre.RequestLanding(this);
        }

        public void TakeOff()
        {
            _commandCentre.RequestTakeOff(this);
        }
 
}
}
