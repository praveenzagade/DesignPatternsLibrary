using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.Models
{
    public class NullCar: IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF NullCar.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning ON NullCar.");
        }
    }
}
