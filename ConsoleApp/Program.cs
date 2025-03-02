using static System.Console;

using ConsoleApp;

DocumentContainer container = new DocumentContainer();

Passport passport = new Passport(
    "Ivanov", "Ivan",
    "photo1.jpg", "01.01.1980", 
    "Male", "Ukrainian", 
    "01.01.2030", "01.01.2020", 
    "P12345678"
);

Military military = new Military(
    "Petrov", "Petr",
    "photo2.jpg", "15.03.1990", 
    "Male", "M1234567", "01.01.2025", 
    "Colonel"
);

Car car1 = new Car("Toyota", "AB1234", "VIN12345");
Car car2 = new Car("BMW", "CD5678", "VIN67890");

List<string> category = new List<string> { "A", "B", "C1" };
List<Car> cars = new List<Car> { car1, car2 };

DriveLicense driveLicense = new DriveLicense(
    "Petrov", "Petr", 
    "photo3.jpg", "15.03.1990", 
    "Male", "DL123456",
    category, cars
);

container.addDoc(passport);
container.addDoc(military);
container.addDoc(driveLicense);

container.SetOutput(WriteLine);

WriteLine("== ALL Document ==");
container.showAllInfo();