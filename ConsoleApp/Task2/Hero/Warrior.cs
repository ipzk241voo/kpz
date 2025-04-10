using ConsoleApp.Task2.Interface;

namespace ConsoleApp.Task2.Hero
{
    internal class Warrior: IHero
    {
        public string GetDescription() => "Warrior";
        public int GetPower() => 10;
    }
}
