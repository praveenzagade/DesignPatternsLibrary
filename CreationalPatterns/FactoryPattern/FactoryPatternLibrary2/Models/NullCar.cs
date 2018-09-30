using FactoryPatternLibrary2.Interfaces;
using System;

namespace FactoryPatternLibrary2.Models
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
