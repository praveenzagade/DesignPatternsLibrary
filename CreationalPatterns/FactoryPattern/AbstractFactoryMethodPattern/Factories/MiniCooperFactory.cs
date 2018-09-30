using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.Factories
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            throw new NotImplementedException();
        }
    }
}
