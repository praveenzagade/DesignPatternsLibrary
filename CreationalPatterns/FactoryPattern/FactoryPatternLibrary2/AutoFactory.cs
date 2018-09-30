using FactoryPatternLibrary2.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPatternLibrary2
{
    public class AutoFactory
    {
        Dictionary<string, Type> _autos;
        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            _autos = new Dictionary<string, Type>();

            Type[] typeInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typeInThisAssembly)
            {
                _autos.Add(type.Name.ToLower(), type);
            }
        }

        public IAuto CreateInstance(CarType carType)
        {
            Type t = GetTypeToCreate(carType);
            if (t == null)
            {
                return null;
            }
            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(CarType carType)
        {
            foreach (var auto in _autos)
            {
                if (auto.Key.Contains(carType.ToString().ToLower()))
                {
                    return _autos[auto.Key];
                }

            }
            return null;
        }
    }
}
