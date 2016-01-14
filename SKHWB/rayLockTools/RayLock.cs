using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.rayLockTools
{
    class RayLock
    {
        private static string SecCode = "RAYSM";
        private static string RaySys = "WS";
        private static string InfTit = "Rpg";
        private static string InfDsc = "وب سرویس گزارشات";

        public static bool fSetLock(){
            return true;
        }
        public static bool removeLock() {
            return true;
        }
        public static bool CheckLock() {
            return true;
        }
    }
}
