using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHoliday;
using NUnit.Framework;

namespace NHolidayTests
{
    [TestFixture]
    public class JapanTests
    {
        [Test]
        [TestCase(2016,1,1, ExpectedResult = true)]
        [TestCase(2016,1,2, ExpectedResult = false)]
        [TestCase(2017,1,1, ExpectedResult = true)]
        [TestCase(2017,1,2, ExpectedResult = true)]
        [TestCase(2017,1,3, ExpectedResult = false)]
        public bool IsHoliday_NewYearsEve(int year, int month, int day)
        {
            return Japan.IsPublicHoliday(new DateTime(year, month, day));
        }


        [Test]
        [TestCase(2016, 1, 1, ExpectedResult = true)]
        [TestCase(2016, 1, 2, ExpectedResult = false)]
        [TestCase(2017, 1, 1, ExpectedResult = true)]
        [TestCase(2017, 1, 2, ExpectedResult = true)]
        [TestCase(2017, 1, 3, ExpectedResult = false)]
        [TestCase(2017, 2, 1, ExpectedResult = false)]
        public bool IsNewYearsEve(int year, int month, int day)
        {
            return Japan.IsNewYearsDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2015, 1, 11, ExpectedResult = false)]
        [TestCase(2015, 1, 12, ExpectedResult = true)]
        [TestCase(2015, 1, 13, ExpectedResult = false)]
        [TestCase(2016, 1, 10, ExpectedResult = false)]
        [TestCase(2016, 1, 11, ExpectedResult = true)]
        [TestCase(2016, 1, 12, ExpectedResult = false)]
        [TestCase(2017, 1, 8, ExpectedResult = false)]
        [TestCase(2017, 1, 9, ExpectedResult = true)]
        [TestCase(2017, 1, 10, ExpectedResult = false)]
        public bool IsComingOfAgeDay(int year, int month, int day)
        {
            return Japan.IsComingOfAgeDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2015, 2, 10, ExpectedResult = false)]
        [TestCase(2015, 2, 11, ExpectedResult = true)]
        [TestCase(2015, 2, 12, ExpectedResult = false)]
        [TestCase(2016, 2, 10, ExpectedResult = false)]
        [TestCase(2016, 2, 11, ExpectedResult = true)]
        [TestCase(2016, 2, 12, ExpectedResult = false)]
        [TestCase(2018, 2, 10, ExpectedResult = false)]
        [TestCase(2018, 2, 11, ExpectedResult = true)]
        [TestCase(2018, 2, 12, ExpectedResult = true)]
        [TestCase(2018, 2, 13, ExpectedResult = false)]
        public bool IsFoundationDay(int year, int month, int day)
        {
            return Japan.IsFoundationDay(new DateTime(year, month, day));
        }
    }
}
