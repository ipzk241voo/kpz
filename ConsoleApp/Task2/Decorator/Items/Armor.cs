using ConsoleApp.Task2.Interface;
namespace ConsoleApp.Task2.Decorator.Items
{
    internal class Armor: HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return _hero.GetDescription() + ", Armor";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 3;
        }
    }
}
