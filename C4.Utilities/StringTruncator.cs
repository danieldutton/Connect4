using C4.Utilities.Interfaces;
using System;

namespace C4.Utilities
{
    public class StringTruncator : IStringTruncator
    {
        public string Truncate(string stringValue)
        {
            if (stringValue == string.Empty) return "Unknown";
            if (stringValue == null) throw new ArgumentNullException("stringValue");
            
            const int maxlength = 10;

            if (stringValue.Length > maxlength)
                stringValue = stringValue.Substring(0, maxlength);
            
            return stringValue;
        }
    }
}
