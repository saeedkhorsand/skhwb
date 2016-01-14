using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SKHWB.ExtensionsMethod
{
    public static class ExtensionsMethod
    {
        #region string
        [Obsolete("Please Use UnderLined Methods", false)]
        public static string RemoveDigits(this string key)
        {
            return Regex.Replace(key, @"\d", "");
        }
        public static int? _GetDigit(this string InputString)
        {
            var R = Regex.Match(InputString, @"\d+").Value;
            if (String.IsNullOrEmpty(R))
                return null;
            return Convert.ToInt32(R);
        }
        public static string _RemoveDigits(this string key)
        {
            return Regex.Replace(key, @"\d", "");
        }
        [Obsolete("Please Use UnderLined Methods", false)]
        public static int ToInt32(this string InputString)
        {
            return Convert.ToInt32(InputString);
        }
        public static int _ToInt32(this string InputString)
        {
            return Convert.ToInt32(InputString);
        }
        [Obsolete("Please Use UnderLined Methods", false)]
        public static double ToDouble(this string InputString)
        {
            return Convert.ToDouble(InputString);
        }
        public static double _ToDouble(this string InputString)
        {
            return Convert.ToDouble(InputString);
        }
        [Obsolete("Please Use UnderLined Methods", false)]
        public static int SubInt(this int InputInt, int start, int length)
        {
            return InputInt.ToString().Substring(start, length)._ToInt32();
        }

        public static bool _ContainsAll(this string InputString, params string[] param)
        {
            foreach (string row in param)
            {
                if (!InputString.Contains(row))
                    return false;
            }
            return true;
        }
        public static bool _ContainsAny(this string InputString, params string[] param)
        {
            foreach (string row in param)
            {
                if (InputString.Contains(row))
                    return true;
            }
            return false;
        }
        #endregion string

        #region int
        public static int _SubInt(this int InputInt, int start, int length)
        {
            return InputInt.ToString().Substring(start, length)._ToInt32();
        }
        public static bool _InRange(this decimal InputInt, decimal min, decimal max)
        {
            return (InputInt >= min) ? (InputInt <= max) ? true : false : false;
        }
        public static bool _IsRayPersianDate(this decimal InputInt)
        {
            return InputInt._InRange(10000000, 99999999);
        }
        #endregion int

        #region object
        [Obsolete("Please Use UnderLined Methods", false)]
        public static T FillFrom<T>(this object From, object To)
        {
            foreach (var Param in To.GetType().GetProperties().ToList())
            {
                try
                {
                    To.GetType().GetProperty(Param.Name).SetValue(To,
                        From.GetType().GetProperty(Param.Name).GetValue(From, null), null);

                }
                catch {/*If Property Not Exists Dont Return Error*/ }
            }

            return (T)To;
        }
        public static T _FillTo<T>(this object From, ref object To)
        {
            foreach (var Param in To.GetType().GetProperties().ToList())
            {
                try
                {
                    To.GetType().GetProperty(Param.Name).SetValue(To,
                        From.GetType().GetProperty(Param.Name).GetValue(From, null), null);

                }
                catch {/*If Property Not Exists Dont Return Error*/ }
            }

            return (T)To;
        }
        #endregion object
    }

}
