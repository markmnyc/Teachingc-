using System;
using ObjectOrientatedLanguage.Models;

namespace ObjectOrientatedLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car marksCar = new Car();
            marksCar.Brand = "Toyota";
            marksCar.Color = "Red";
            //marksCar.numberOfDoorHandles = 6;

            Car nelliesCar = new Car();
            //nelliesCar.NumberOfDoors = 4;
            nelliesCar.isCarStarted();
            //nelliesCar.NumberOfTyres = 2;

            Console.WriteLine(marksCar);
            Console.WriteLine(nelliesCar.NumberOfDoors.ToString());
            //Console.WriteLine(nelliesCar.NumberOfDoorHandles);
            Console.WriteLine(nelliesCar.Color);
            Console.ReadLine();

            Console.WriteLine(nelliesCar.NumberOfTyres.ToString());
            Console.WriteLine(nelliesCar.Color);
            Console.ReadLine();

        }
    }
}
