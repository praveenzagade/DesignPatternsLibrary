using AbstractFactoryMethodPattern.Interfaces;
using System;

namespace AbstractFactoryMethodPattern.Factories
{
    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            throw new NotImplementedException();
        }
    }
}
