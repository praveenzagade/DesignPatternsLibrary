using FactoryPatternLibrary2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLibrary2.Models
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
