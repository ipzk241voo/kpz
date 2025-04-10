namespace ConsoleApp.Task5.Unit
{
    internal class Character
    {
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }

        public override string ToString()
        {
            return $"Height: {Height}, Build: {Build}, HairColor: {HairColor}, EyeColor: {EyeColor}, Clothing: {Clothing}, Inventory: {string.Join(", ", Inventory)}";
        }
    }
}
