
using ConsoleApp.Task2.Interface;

namespace ConsoleApp.Task2.Hero
{
    internal class Paladin: IHero
    {
        public string GetDescription() => "Paladin";
        public int GetPower() => 9;
    }
}
