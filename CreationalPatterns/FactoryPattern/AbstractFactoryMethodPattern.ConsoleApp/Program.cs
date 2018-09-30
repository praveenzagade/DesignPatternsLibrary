using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.ConsoleApp
{
    class Program
    {
        static CarType _carType;
        static void Main(string[] args)
        {
            Console.WriteLine("Provide required car type : ");
            Console.WriteLine("BMW : 0 \nMiniCooper : 1 \nAudi : 2");
            _carType = (CarType)Convert.ToInt32(Console.ReadLine());
            IAutoFactory autoFactory = LoadFactory();

            IAuto car = autoFactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();
            Console.ReadLine();
        }

        private static IAutoFactory LoadFactory()
        {
            //string factoryName = Properties.Settings.Default.AutoFactory;
            //return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
            switch (_carType)
            {
                case CarType.BMW:
                    break;
                case CarType.MiniCooper:
                    return new Factories.MiniCooperFactory();

                case CarType.Audi:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
