namespace ConsoleApp.Task5.Unit
{
    internal interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder SetInventory(List<string> inventory);
        Character GetResult();

        ICharacterBuilder DoGoodDeed(string name);
        ICharacterBuilder DoEvilDeed(string name);
    }
}
