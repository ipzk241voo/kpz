using ConsoleApp.Task2.Brand;
using ConsoleApp.Task2.Factory;
using ConsoleApp.Task2.Device;
using static System.Console;


ITechFactory FBalaxy = new Balaxy();
IDevice laptop = FBalaxy.CreateDevice("Laptop");
WriteLine(laptop.Info());

ITechFactory FIPhone = new IPhone();
IDevice smartphone = FIPhone.CreateDevice("SmartPhone");
WriteLine(smartphone.Info());


ITechFactory FKiaomi = new Kiaomi();
IDevice Netbook = FKiaomi.CreateDevice("Netbook");
WriteLine(Netbook.Info());