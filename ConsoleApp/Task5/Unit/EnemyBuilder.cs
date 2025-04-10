using static System.Console;

namespace ConsoleApp.Task5.Unit
{
    internal class EnemyBuilder : ICharacterBuilder
    {
        private Character enemy = new Character();

        public ICharacterBuilder SetHeight(double height)
        {
            enemy.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            enemy.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            enemy.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            enemy.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            enemy.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            enemy.Inventory = inventory;
            return this;
        }

        public Character GetResult()
        {
            return enemy;
        }

        public ICharacterBuilder DoEvilDeed(string deed)
        {
            WriteLine($"Enemy did evil deed: {deed}");
            return this;
        }

        public ICharacterBuilder DoGoodDeed(string name)
        {
            throw new NotImplementedException();
        }
    }
}
