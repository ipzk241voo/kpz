using static System.Console;

namespace ConsoleApp.Task4
{
    internal class Virus: ICloneable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Species = species;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Species, Weight, Age);
            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }
            return clone;
        }

        public void PrintFamily(int level = 0)
        {
            WriteLine($"{new string('-', level * 2)}> {Name} ({Species}), Age: {Age}, Weight: {Weight}g");
            foreach (var child in Children)
            {
                child.PrintFamily(level + 1);
            }
        }
    }
}
