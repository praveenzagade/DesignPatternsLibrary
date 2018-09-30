using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.Models
{
    public class MiniCooper : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF MiniCooper.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning ON MiniCooper.");
        }
    }
}
