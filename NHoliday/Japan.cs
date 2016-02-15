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

            var comingOfAgeDate = DateTimeHelper.FindDay(dateTime.Year, dateTime.Month, DayOfWeek.Monday, 2);

            return dateTime.Day == comingOfAgeDate;
        }

        public static bool IsFoundationDay(DateTime dateTime)
        {
            if (dateTime.Month != 2) return false;

            if (dateTime.Day == 11) return true;

             return dateTime.Day == 12 && dateTime.DayOfWeek == DayOfWeek.Monday;
        }

        public static bool IsVernalEquinoxDay(DateTime dateTime, bool ignoreStaleInfo = true)
        {
            if (dateTime.Month != 3) return false;

            var equinoxDateTime = EquinoxDates.GetVernalEquinoxDateTime(dateTime.Year);
            
            var eq = equinoxDateTime.AddHours(9);

            if (eq.Day == dateTime.Day)
                return true;

            return eq.DayOfWeek == DayOfWeek.Sunday && eq.Day + 1 == dateTime.Day;
        }

        public static bool IsShowaDay(DateTime dateTime)
        {
            if (dateTime.Month != 4) return false;

            if (dateTime.Day == 29) return true;

            return dateTime.Day == 30 && dateTime.DayOfWeek == DayOfWeek.Monday;
        }

        public static bool IsConstitutionMemorialDay(DateTime dateTime)
        {
            if (dateTime.Month != 5) return false;

            if (dateTime.Day == 3) return true;

            return dateTime.Day == 6 && dateTime.DayOfWeek == DayOfWeek.Wednesday;
        }

        public static bool IsGreeneryDay(DateTime dateTime)
        {
            if (dateTime.Month != 5) return false;

            if (dateTime.Day == 4) return true;

            return dateTime.Day == 6 && dateTime.DayOfWeek == DayOfWeek.Tuesday;
        }

        public static bool IsChildrensDay(DateTime dateTime)
        {
            if (dateTime.Month != 5) return false;

            if (dateTime.Day == 5) return true;

            return dateTime.Day == 6 && dateTime.DayOfWeek == DayOfWeek.Monday;
        }
    }
}