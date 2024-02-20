// See https://aka.ms/new-console-template for more information
using CarAssemblyLine;
using CarAssemblyLine.Decorator;

ICar car = new Car();
ICar luxurySportsCar = new LuxuryCar(new SportsCar(car));

luxurySportsCar.Assemble();
Console.WriteLine();
Console.WriteLine(luxurySportsCar.Drive());