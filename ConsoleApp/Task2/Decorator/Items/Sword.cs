using ConsoleApp.Task2.Interface;
namespace ConsoleApp.Task2.Decorator
{
    internal class Sword: HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return _hero.GetDescription() + ", Sword";
        }

        public override int GetPower()
        {
            return _hero.GetPower() + 5;
        }
    }
}
