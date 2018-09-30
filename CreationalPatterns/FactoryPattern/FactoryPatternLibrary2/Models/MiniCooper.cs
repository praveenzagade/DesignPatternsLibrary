﻿using FactoryPatternLibrary2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternLibrary2.Models
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
