using C4.Utilities.Interfaces;
using System;

namespace C4.Utilities
{
    public class NameFormatter : INameFormatter
    {
        public string FormatName(string nameToFormat)
        {
            if (nameToFormat == string.Empty) return "Unknown";
            if (nameToFormat == null) throw new ArgumentNullException("nameToFormat");
            
            const int maxlength = 10;

            if (nameToFormat.Length > maxlength)
                nameToFormat = nameToFormat.Substring(0, maxlength);
            
            return nameToFormat;
        }
    }
}
