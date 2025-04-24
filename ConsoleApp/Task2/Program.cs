using static System.Console;
using ConsoleApp.Task2;

Runway runway1 = new Runway();
Runway runway2 = new Runway();
CommandCentre commandCentre = new CommandCentre(new[] { runway1, runway2 });

Aircraft[] aircraftArray = {
     new Aircraft("Boeing 737", commandCentre),
     new Aircraft("Airbus A320", commandCentre),
     new Aircraft("F-16", commandCentre)
};

foreach (Aircraft aircraft in aircraftArray)
{
    commandCentre.RegisterAircraft(aircraft);
}

aircraftArray[0].Land();

aircraftArray[1].Land();

aircraftArray[2].Land(); // dont work

aircraftArray[0].TakeOff();

aircraftArray[2].Land(); // work

ReadKey();