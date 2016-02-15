using System;
using NHoliday;
using NUnit.Framework;

namespace NHolidayTests
{
    [TestFixture]
    public class DateTimeHelperTests
    {
        [Test]
        public bool CountOfLeapYearsBetweenYears(int year, int month, int day)
        {
            return Japan.IsPublicHoliday(new DateTime(year, month, day));
        }
    }
}