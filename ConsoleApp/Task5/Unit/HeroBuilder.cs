using static System.Console;

namespace ConsoleApp.Task5.Unit
{
    internal class HeroBuilder : ICharacterBuilder
    {
        private Character hero = new Character();

        public ICharacterBuilder SetHeight(double height)
        {
            hero.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            hero.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            hero.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            hero.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            hero.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            hero.Inventory = inventory;
            return this;
        }

        public Character GetResult()
        {
            return hero;
        }

        public ICharacterBuilder DoGoodDeed(string deed)
        {
            WriteLine($"Hero did good deed: {deed}");
            return this;
        }

        public ICharacterBuilder DoEvilDeed(string name)
        {
            throw new NotImplementedException();
        }
    }
}
