using FactoryPatternLibrary1.Interfaces;
using System;

namespace FactoryPatternLibrary1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide required car type : ");
            Console.WriteLine("BMW : 0 \nMiniCooper : 1 \nAudi : 2");
            CarType input = (CarType)Convert.ToInt32(Console.ReadLine());

            // VIOLATES OPEN CLOSE PRINCIPLE OF SOLID DESIGN PRINCIPLES
            IAuto car = AutoFactory.GetCar(input);

            car.TurnOn();
            car.TurnOff();
            Console.ReadLine();
        }
    }
}
