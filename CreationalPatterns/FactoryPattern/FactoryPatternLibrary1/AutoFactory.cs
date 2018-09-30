using FactoryPatternLibrary1.Interfaces;
using FactoryPatternLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLibrary1
{
    // VIOLATES OPEN CLOSE PRINCIPLE OF SOLID DESIGN PRINCIPLES
    public class AutoFactory
    {
        public static IAuto GetCar(CarType carType)
        {
            IAuto retType = null;
            switch (carType)
            {
                case CarType.BMW:
                    retType = new BMW335Xi();
                    break;
                case CarType.MiniCooper:
                    retType = new MiniCooper();
                    break;
                case CarType.Audi:
                    retType = new AudiTTS();
                    break;
                default:
                    break;
            }
            return retType;
        }
    }
}
