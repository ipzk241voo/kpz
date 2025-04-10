using static System.Console;
using ConsoleApp.Task2.Decorator.Items;
using ConsoleApp.Task2.Decorator;
using ConsoleApp.Task2.Hero;
using ConsoleApp.Task2.Interface;

IHero hero = new Paladin();

hero = new Armor(hero);
hero = new Shield(hero);
hero = new RingOfHealth(hero);
hero = new Sword(hero);

WriteLine("Description: " + hero.GetDescription());
WriteLine("Power: " + hero.GetPower());