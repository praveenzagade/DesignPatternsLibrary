using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.Models
{
    public class AudiTTS : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF AudiTTS.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning ON AudiTTS.");
        }
    }
}
