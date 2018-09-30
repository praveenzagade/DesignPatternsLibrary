using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.Models
{
    public class BMW335Xi : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF BMW335Xi.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning ON BMW335Xi.");
        }
    }
}
