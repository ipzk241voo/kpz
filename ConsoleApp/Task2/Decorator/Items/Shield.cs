using ConsoleApp.Task2.Interface;

namespace ConsoleApp.Task2.Decorator.Items
{
    internal class Shield: HeroDecorator
    {
        public Shield(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return _hero.GetDescription() + ", Shield";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 5;
        }
    }
}
