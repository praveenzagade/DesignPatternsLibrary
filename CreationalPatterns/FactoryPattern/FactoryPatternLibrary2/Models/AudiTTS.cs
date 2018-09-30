using FactoryPatternLibrary2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLibrary2.Models
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
