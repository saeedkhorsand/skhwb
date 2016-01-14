using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using SKHWB.ExtensionsMethod;
namespace SKHWB.publicTools
{
    public class CalenderMng
    {
        private static PersianCalendar PC = new PersianCalendar();
        private static Dictionary<int, List<int>> Holidays = new Dictionary<int, List<int>>();
        public static int ConvertDateToDayOfYear(int Date)
        {
            return PC.GetDayOfYear(PC.ToDateTime(Date.SubInt(0, 4), Date.SubInt(4, 2), Date.SubInt(6, 2),
                                        0, 0, 0, 0));
        }
        public static int ConvertDayOfYearToDate(int Year, int DayOfyear)
        {
            int Month = 1;
            string Date = Year.ToString();
            while (true)
            {
                if (Month <= 6)
                {
                    if (DayOfyear <= 31)
                        break;
                    DayOfyear -= 31;
                    Month++;
                }
                else if (Month <= 11)
                {
                    if (DayOfyear <= 30)
                        break;
                    DayOfyear -= 30;
                    Month++;
                }
                else
                {
                    break;
                }
            }
            Date += Month < 10 ? "0" + Month.ToString() : Month.ToString();
            Date += DayOfyear < 10 ? "0" + DayOfyear.ToString() : DayOfyear.ToString();
            return Date.ToInt32();
        }
        public static int RayConvertDayOfYearToDAte(int InputYearAndDayOfYear)
        {
            return ConvertDayOfYearToDate(InputYearAndDayOfYear.SubInt(0, 4),
                                            InputYearAndDayOfYear.ToString().Remove(0, 4).ToInt32());
        }
        public static int GetCurrentPersianDate()
        {
            string Date = PC.GetYear(DateTime.Now).ToString();
            Date += PC.GetMonth(DateTime.Now) < 10 ? "0" + PC.GetMonth(DateTime.Now).ToString() : PC.GetMonth(DateTime.Now).ToString();
            Date += PC.GetDayOfMonth(DateTime.Now) < 10 ? "0" + PC.GetDayOfMonth(DateTime.Now).ToString() : PC.GetDayOfMonth(DateTime.Now).ToString();
            return Date.ToInt32();
        }
        public static int GetCurrentDayOfWeek()
        {
            return PC.GetDayOfWeek(DateTime.Now).ToString().ToInt32() + 1;
        }
        public static int GetLastDayOfYear(int year)
        {
            return 365;
        }
        public static List<int> CalculateHolidays(int year, int typ = 0)
        {
            if (Holidays.Count == 0)
            {
                Holidays.Add(1392, new List<int>() { 1, 2, 3, 4, 5 });
                Holidays.Add(1393, new List<int>());
                Holidays.Add(1394, new List<int>());
                Holidays.Add(1395, new List<int>());
                Holidays.Add(1396, new List<int>());
                Holidays.Add(1397, new List<int>());
                Holidays.Add(1398, new List<int>());
            }

            if (Holidays.ContainsKey(year))
                if (typ == 0)
                    return Holidays[year];
                else
                {
                    return Holidays[year].Select(Day => ConvertDayOfYearToDate(year, Day)).ToList();
                }
            return new List<int>();
        }
    }
}
