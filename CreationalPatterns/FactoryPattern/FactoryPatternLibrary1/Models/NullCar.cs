using FactoryPatternLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLibrary.Models
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
