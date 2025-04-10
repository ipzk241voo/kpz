using static System.Console;
using ConsoleApp.Task4;

Virus parent = new Virus("Root", "Alpha", 10.0, 5);
Virus child1 = new Virus("Child1", "Beta", 5.0, 2);
Virus child2 = new Virus("Child2", "Gamma", 3.0, 1);
Virus grandchild1 = new Virus("Grandchild1", "Delta", 1.0, 0);

parent.AddChild(child1);
parent.AddChild(child2);
child1.AddChild(grandchild1);

WriteLine("Original Family:");
parent.PrintFamily();

Virus clonedParent = (Virus)parent.Clone();

WriteLine("\nCloned Family:");
clonedParent.PrintFamily();

WriteLine($"Original and cloned objects are the same: {ReferenceEquals(parent, clonedParent)}");
WriteLine($"Original child1 and cloned child1 are the same: {ReferenceEquals(parent.Children[0], clonedParent.Children[0])}");