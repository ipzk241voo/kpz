using static System.Console;

namespace ConsoleApp.Task2
{
    internal class CommandCentre : ICommandCentre
    {
        private readonly List<Runway> _runways = new List<Runway>();
        private readonly List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(IEnumerable<Runway> runways) => _runways.AddRange(runways);

        public void RegisterAircraft(Aircraft aircraft) => _aircrafts.Add(aircraft);

        public void RequestLanding(Aircraft aircraft)
        {
            WriteLine($"\nAircraft {aircraft.Name} is requesting to land.");

            var availableRunway = _runways.FirstOrDefault(r => r.IsAvailable);
            if (availableRunway != null)
            {
                WriteLine($"Aircraft {aircraft.Name} has landed on Runway {availableRunway.Id}.");
                availableRunway.IsBusyWithAircraft = aircraft;
                availableRunway.HighLightRed();
            }
            else
            {
                WriteLine("No available runways. Aircraft must wait.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            WriteLine($"\nAircraft {aircraft.Name} is requesting to take off.");

            var assignedRunway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft == aircraft);
            if (assignedRunway != null)
            {
                aircraft.IsTakingOff = true;
                assignedRunway.IsBusyWithAircraft = null;
                assignedRunway.HighLightGreen();
                WriteLine($"Aircraft {aircraft.Name} has taken off from Runway {assignedRunway.Id}.");
            }
            else
            {
                WriteLine("Take-off failed: Aircraft is not assigned to any runway.");
            }
        }
    }
}
