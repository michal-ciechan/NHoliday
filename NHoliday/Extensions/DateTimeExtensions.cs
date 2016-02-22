using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHoliday.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool IsFirstXDayOfMonth(this DateTime dateTime, DayOfWeek dayOfWeek, int x)
        {
            return dateTime.Day == DateTimeHelper.FindDay(dateTime.Year, dateTime.Month, dayOfWeek, x);
        }
    }
}
