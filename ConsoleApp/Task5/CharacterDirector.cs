using ConsoleApp.Task5.Unit;

namespace ConsoleApp.Task5
{
    internal class CharacterDirector
    {
        public Character ConstructHero(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(1.80)
                .SetBuild("Athletic")
                .SetHairColor("Blonde")
                .SetEyeColor("Blue")
                .SetClothing("Armor")
                .SetInventory(new List<string> { "Sword", "Shield", "Potion" })
                .DoGoodDeed("Saved a village")
                .GetResult();
        }

        public Character ConstructEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(2.10)
                .SetBuild("Muscular")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothing("Dark robes")
                .SetInventory(new List<string> { "Axe", "Dark magic staff" })
                .DoEvilDeed("Destroyed a city")
                .GetResult();
        }
    }
}
