using System;

namespace NHoliday
{
    public class Japan
    {
        public static bool IsPublicHoliday(DateTime input)
        {
            throw new NotImplementedException();
        }

        public static bool IsNewYearsDay(DateTime dateTime)
        {
            if (dateTime.Month != 1) return false;
            
            // Rolled over from Sunday 1st Jan
            if (dateTime.Day == 2 && dateTime.DayOfWeek == DayOfWeek.Monday)
                return true;

            return dateTime.Day == 1;
        }

        public static bool IsComingOfAgeDay(DateTime dateTime)
        {
            if (dateTime.Month != 1) return false;

            var comingOfAgeDate = DayFinder.FindDay(dateTime.Year, dateTime.Month, DayOfWeek.Monday, 2);

            return dateTime.Day == comingOfAgeDate;
        }

        public static bool IsFoundationDay(DateTime dateTime)
        {
            if (dateTime.Month != 2) return false;

            if (dateTime.Day == 11) return true;

             return dateTime.Day == 12 && dateTime.DayOfWeek == DayOfWeek.Monday;
        }
    }
}