using ConsoleApp.Task2.Interface;

namespace ConsoleApp.Task2.Decorator.Items
{
    internal class MagicRing : HeroDecorator
    {
        public MagicRing(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return _hero.GetDescription() + ", Magic Ring";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 7;
        }
    }
}
