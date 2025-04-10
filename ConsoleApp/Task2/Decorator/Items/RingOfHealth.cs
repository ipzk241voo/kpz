using ConsoleApp.Task2.Interface;
namespace ConsoleApp.Task2.Decorator.Items
{
    internal class RingOfHealth: HeroDecorator
    {
        public RingOfHealth(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return _hero.GetDescription() + ", Ring of Health";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 4;
        }
    }
}
