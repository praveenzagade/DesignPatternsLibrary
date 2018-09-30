using FactoryPatternLibrary2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLibrary2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide required car type : ");
            Console.WriteLine("BMW : 0 \nMiniCooper : 1 \nAudi : 2");
            CarType carType = (CarType)Convert.ToInt32(Console.ReadLine());
            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carType);

            car.TurnOn();
            car.TurnOff();
            Console.ReadLine();
        }
    }
}
