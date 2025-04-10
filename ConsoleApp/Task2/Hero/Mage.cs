using ConsoleApp.Task2.Interface;

namespace ConsoleApp.Task2.Hero
{
    internal class Mage: IHero
    {
        public string GetDescription() => "Mage";
        public int GetPower() => 8;
    }
}
