using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Colors
{
    public static class DefaultSettings
    {
        public static Color ReadSettings()
        {

            Properties.Settings settings = new Properties.Settings();
            Color color = new Color()
            {
                A = 255,
                R = settings.R,
                G = settings.G,
                B = settings.B
            };
            return color;
        }

        public static void SaveSettings(Color color)
        {
            Properties.Settings settings = new Properties.Settings();
            settings.R = color.R;
            settings.G = color.G;
            settings.B = color.B;
            settings.Save();
        }
        

    }
}
