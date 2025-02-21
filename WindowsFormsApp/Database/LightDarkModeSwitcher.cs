using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Database
{
    public class LightDarkModeSwitcher
    {
        private static bool isLightMode = true;

        public static bool GetIsLightMode()
        {
            return isLightMode;
        }

        public static void ToggleMode()
        {
            isLightMode = !isLightMode;
        }
    }
}
