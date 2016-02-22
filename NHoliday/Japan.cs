using System;
using System.Collections.Generic;
using NHoliday.Extensions;

namespace NHoliday
{
    public class Japan
    {
        public static bool IsPublicHoliday(DateTime input)
        {
            switch (input.Month)
            {
                case 1:
                    return IsNewYearsDay(input) 
                        || IsComingOfAgeDay(input);
                case 2:
                    return IsFoundationDay(input);
                case 3:
                    return IsVernalEquinoxDay(input);
                case 4:
                    return IsShowaDay(input);
                case 5:
                    return IsConstitutionMemorialDay(input)
                           || IsGreeneryDay(input)
                           || IsChildrensDay(input);
                case 6:
                    return false;
                case 7:
                    return IsSeaDay(input);
                case 8:
                    return IsMountainDay(input);
                case 9:
                    return IsRespectForTheAgedDay(input)
                        || IsAutumnalEquinoxDay(input);
                case 10:
                    return IsSportsDay(input);
                case 11:
                    return IsCultureDay(input)
                        || IsThanksgivingDay(input);
                case 12:
                    return IsEmporerAkihitosBirthday(input);
                default:
                    return false;
            }
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
            
            // Vernal Equinox DateTime in JST (UTC+9)
            var eq = equinoxDateTime.AddHours(9);

            return IsDayOrTransferedHoliday(dateTime, eq.Day);
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

            return IsDayOrTransferedHoliday(dateTime, 5);
        }

        public static bool IsDayOrTransferedHoliday(DateTime dateTime, int i)
        {
            if (dateTime.Day == i) return true;

            return dateTime.Day == i+1 && dateTime.DayOfWeek == DayOfWeek.Monday;
        }

        public static bool IsSeaDay(DateTime dateTime)
        {
            if (dateTime.Month != 7) return false;

            return dateTime.IsFirstXDayOfMonth(DayOfWeek.Monday, 3);
        }

        public static bool IsMountainDay(DateTime dateTime)
        {
            // First time observed in 1966
            if (dateTime.Year < 2016) return false;

            if (dateTime.Month != 8) return false;

            return IsDayOrTransferedHoliday(dateTime, 11);
        }

        public static bool IsRespectForTheAgedDay(DateTime dateTime)
        {
            // First time observed in 1966
            if (dateTime.Year < 1966) return false;

            if (dateTime.Month != 9) return false;

            if (dateTime.Year < 2003)
                return IsDayOrTransferedHoliday(dateTime, 15);

            return dateTime.IsFirstXDayOfMonth(DayOfWeek.Monday, 3);
        }

        public static bool IsAutumnalEquinoxDay(DateTime dateTime)
        {
            if (dateTime.Year < 1948) return false;

            if (dateTime.Month != 9) return false;

            var equinoxDateTime = EquinoxDates.GetAutumnalEquinoxDateTime(dateTime.Year);

            // Vernal Equinox DateTime in JST (UTC+9)
            var eq = equinoxDateTime.AddHours(9);

            return IsDayOrTransferedHoliday(dateTime, eq.Day);
        }

        public static bool IsSportsDay(DateTime dateTime)
        {
            if (dateTime.Year < 1966) return false;

            if (dateTime.Month != 10) return false;

            if (dateTime.Year < 2000) // Pre Happy Monday
                return IsDayOrTransferedHoliday(dateTime, 10);
            
            return dateTime.IsFirstXDayOfMonth(DayOfWeek.Monday, 2);
        }

        public static bool IsCultureDay(DateTime dateTime)
        {
            if (dateTime.Year < 1868) return false;

            if (dateTime.Month != 11) return false;

            if (dateTime.Year >= 1912 && dateTime.Year < 1927)
                return false; // After Emperor Meiji Died, and before it became holiday
            
            return IsDayOrTransferedHoliday(dateTime, 3);
        }

        public static bool IsThanksgivingDay(DateTime dateTime)
        {
            if (dateTime.Year < 1948) return false;

            if (dateTime.Month != 11) return false;
            
            return IsDayOrTransferedHoliday(dateTime, 23);
        }

        public static bool IsEmporerAkihitosBirthday(DateTime dateTime)
        {
            if (dateTime.Year < 1989) return false;

            if (dateTime.Month != 12) return false;
            
            return IsDayOrTransferedHoliday(dateTime, 23);
        }

        public static bool IsDecemberBankHoliday(DateTime date)
        {
            if (date.Year < 1993) return false;

            if (date.Month != 12) return false;

            return date.Day == 31;
        }

        public static bool IsJanuaryBankHoliday(DateTime date)
        {
            if (date.Year < 1994) return false;

            if (date.Month != 1) return false;

            return date.Day == 2 || date.Day == 3;
        }

        public static List<DateTime> ListPublicHolidays(int year)
        {
            var list = new List<DateTime>(25);

            var dateTime = new DateTime(year, 1, 1);

            while (dateTime.Year == year)
            {
                if(IsPublicHoliday(dateTime))
                    list.Add(dateTime);

                dateTime = dateTime.AddDays(1);
            }

            return list;
        }

        public static List<DateTime> ListBankHolidays(int year)
        {
            var list = new List<DateTime>(5);

            var dateTime = new DateTime(year, 1, 1);

            while (dateTime.Year == year)
            {
                if (IsBankHoliday(dateTime))
                    list.Add(dateTime);

                dateTime = dateTime.AddDays(1);
            }

            return list;
        }

        public static List<DateTime> ListHolidays(int year)
        {
            var list = new List<DateTime>(25);

            var dateTime = new DateTime(year, 1, 1);

            while (dateTime.Year == year)
            {
                if (IsBankHoliday(dateTime) || IsPublicHoliday(dateTime)) 
                    list.Add(dateTime);

                dateTime = dateTime.AddDays(1);
            }

            return list;
        }

        public static bool IsBankHoliday(DateTime date)
        {
            if (date.Month == 1)
                return IsJanuaryBankHoliday(date);
            if (date.Month == 12)
                return IsDecemberBankHoliday(date);

            return false;
        }
    }
}