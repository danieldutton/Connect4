using C4.WinAnalyser.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace C4.WinAnalyser
{
    public class WinTypeFactory : IWinTypeFactory
    {
        private Dictionary<string, Type> _winTypes;

        
        public WinTypeFactory()
        {
            LoadTypesICanReturn();
        }

        public IFourInARow CreateInstance(string winType)
        {
            if(string.IsNullOrEmpty(winType)) throw new ArgumentException("winType");

            Type type = GetTypeToCreate(winType);

            if (type == null)
                return null;

            return Activator.CreateInstance(type) as IFourInARow;
        }

        private Type GetTypeToCreate(string winType)
        {
            foreach (var wt in _winTypes)
            {
                if (wt.Key.Contains(winType))
                {
                    return _winTypes[wt.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {
            _winTypes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IFourInARow).ToString()) != null)
                {
                    _winTypes.Add(type.Name, type);
                }
            }
        }
    }
}
