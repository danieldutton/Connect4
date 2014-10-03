using System;
using System.IO;
using System.Media;

namespace C4.Presentation.ExtMethods
{
    public static class Extensions
    {
        public static string Truncate(this string stringValue)
        {
            if (stringValue == string.Empty) return "Unknown";
            if (stringValue == null) throw new ArgumentNullException("stringValue");
            
            const int maxlength = 10;

            if (stringValue.Length > maxlength)
                stringValue = stringValue.Substring(0, maxlength);
            
            return stringValue;
        }

        public static void PlaySoundFX(this SoundPlayer sPlayer, Stream resource)
        {
            using (var soundPlayer = new SoundPlayer(resource))
            {
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }
    }
}
