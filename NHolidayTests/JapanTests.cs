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
        public bool IsPublicHoliday_2016(int year, int month, int day)
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

        [Test]
        [TestCase(2010, 3, 20, ExpectedResult = false)]
        [TestCase(2010, 3, 21, ExpectedResult = true)]
        [TestCase(2010, 3, 22, ExpectedResult = true)]
        [TestCase(2010, 3, 23, ExpectedResult = false)]
        [TestCase(2011, 3, 20, ExpectedResult = false)]
        [TestCase(2011, 3, 21, ExpectedResult = true)]
        [TestCase(2011, 3, 22, ExpectedResult = false)]
        [TestCase(2012, 3, 19, ExpectedResult = false)]
        [TestCase(2012, 3, 20, ExpectedResult = true)]
        [TestCase(2012, 3, 21, ExpectedResult = false)]
        [TestCase(2013, 3, 19, ExpectedResult = false)]
        [TestCase(2013, 3, 20, ExpectedResult = true)]
        [TestCase(2013, 3, 21, ExpectedResult = false)]
        [TestCase(2014, 3, 20, ExpectedResult = false)]
        [TestCase(2014, 3, 21, ExpectedResult = true)]
        [TestCase(2014, 3, 22, ExpectedResult = false)]
        [TestCase(2015, 3, 20, ExpectedResult = false)]
        [TestCase(2015, 3, 21, ExpectedResult = true)]
        [TestCase(2015, 3, 22, ExpectedResult = false)]
        [TestCase(2016, 3, 19, ExpectedResult = false)]
        [TestCase(2016, 3, 20, ExpectedResult = true)]
        [TestCase(2016, 3, 21, ExpectedResult = true)]
        [TestCase(2016, 3, 22, ExpectedResult = false)]
        [TestCase(2017, 3, 19, ExpectedResult = false)]
        [TestCase(2017, 3, 20, ExpectedResult = true)]
        [TestCase(2017, 3, 21, ExpectedResult = false)]
        [TestCase(2018, 3, 20, ExpectedResult = false)]
        [TestCase(2018, 3, 21, ExpectedResult = true)]
        [TestCase(2018, 3, 22, ExpectedResult = false)]
        [TestCase(2019, 3, 20, ExpectedResult = false)]
        [TestCase(2019, 3, 21, ExpectedResult = true)]
        [TestCase(2019, 3, 22, ExpectedResult = false)]
        [TestCase(2020, 3, 19, ExpectedResult = false)]
        [TestCase(2020, 3, 20, ExpectedResult = true)]
        [TestCase(2020, 3, 21, ExpectedResult = false)]
        public bool IsVernalEquinoxDay(int year, int month, int day)
        {
            return Japan.IsVernalEquinoxDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2015, 4, 28, ExpectedResult = false)]
        [TestCase(2015, 4, 29, ExpectedResult = true)]
        [TestCase(2015, 4, 30, ExpectedResult = false)]
        [TestCase(2016, 4, 28, ExpectedResult = false)]
        [TestCase(2016, 4, 29, ExpectedResult = true)]
        [TestCase(2016, 4, 30, ExpectedResult = false)]
        [TestCase(2017, 4, 28, ExpectedResult = false)]
        [TestCase(2017, 4, 29, ExpectedResult = true)]
        [TestCase(2017, 4, 30, ExpectedResult = false)]
        [TestCase(2018, 4, 28, ExpectedResult = false)]
        [TestCase(2018, 4, 29, ExpectedResult = true)]
        [TestCase(2018, 4, 30, ExpectedResult = true)]
        [TestCase(2018, 5, 1, ExpectedResult = false)]
        public bool IsShowaDay(int year, int month, int day)
        {
            return Japan.IsShowaDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 5, 2, ExpectedResult = false)]
        [TestCase(2010, 5, 3, ExpectedResult = true)]
        [TestCase(2010, 5, 4, ExpectedResult = false)]
        [TestCase(2011, 5, 2, ExpectedResult = false)]
        [TestCase(2011, 5, 3, ExpectedResult = true)]
        [TestCase(2011, 5, 4, ExpectedResult = false)]
        [TestCase(2012, 5, 2, ExpectedResult = false)]
        [TestCase(2012, 5, 3, ExpectedResult = true)]
        [TestCase(2012, 5, 4, ExpectedResult = false)]
        [TestCase(2013, 5, 2, ExpectedResult = false)]
        [TestCase(2013, 5, 3, ExpectedResult = true)]
        [TestCase(2013, 5, 4, ExpectedResult = false)]
        [TestCase(2014, 5, 2, ExpectedResult = false)]
        [TestCase(2014, 5, 3, ExpectedResult = true)]
        [TestCase(2014, 5, 4, ExpectedResult = false)]
        [TestCase(2015, 5, 2, ExpectedResult = false)]
        [TestCase(2015, 5, 3, ExpectedResult = true)]
        [TestCase(2015, 5, 4, ExpectedResult = false)]
        [TestCase(2015, 5, 5, ExpectedResult = false)]
        [TestCase(2015, 5, 6, ExpectedResult = true)]
        [TestCase(2015, 5, 7, ExpectedResult = false)]
        [TestCase(2016, 5, 2, ExpectedResult = false)]
        [TestCase(2016, 5, 3, ExpectedResult = true)]
        [TestCase(2016, 5, 4, ExpectedResult = false)]
        [TestCase(2017, 5, 2, ExpectedResult = false)]
        [TestCase(2017, 5, 3, ExpectedResult = true)]
        [TestCase(2017, 5, 4, ExpectedResult = false)]
        [TestCase(2018, 5, 2, ExpectedResult = false)]
        [TestCase(2018, 5, 3, ExpectedResult = true)]
        [TestCase(2018, 5, 4, ExpectedResult = false)]
        [TestCase(2019, 5, 2, ExpectedResult = false)]
        [TestCase(2019, 5, 3, ExpectedResult = true)]
        [TestCase(2019, 5, 4, ExpectedResult = false)]
        [TestCase(2020, 5, 2, ExpectedResult = false)]
        [TestCase(2020, 5, 3, ExpectedResult = true)]
        [TestCase(2020, 5, 4, ExpectedResult = false)]
        [TestCase(2020, 5, 5, ExpectedResult = false)]
        [TestCase(2020, 5, 6, ExpectedResult = true)]
        [TestCase(2020, 5, 7, ExpectedResult = false)]
        public bool IsConstitutionMemorialDay(int year, int month, int day)
        {
            return Japan.IsConstitutionMemorialDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 5, 3, ExpectedResult = false)]
        [TestCase(2010, 5, 4, ExpectedResult = true)]
        [TestCase(2010, 5, 5, ExpectedResult = false)]
        [TestCase(2011, 5, 3, ExpectedResult = false)]
        [TestCase(2011, 5, 4, ExpectedResult = true)]
        [TestCase(2011, 5, 5, ExpectedResult = false)]
        [TestCase(2012, 5, 3, ExpectedResult = false)]
        [TestCase(2012, 5, 4, ExpectedResult = true)]
        [TestCase(2012, 5, 5, ExpectedResult = false)]
        [TestCase(2013, 5, 3, ExpectedResult = false)]
        [TestCase(2013, 5, 4, ExpectedResult = true)]
        [TestCase(2013, 5, 5, ExpectedResult = false)]
        [TestCase(2014, 5, 3, ExpectedResult = false)]
        [TestCase(2014, 5, 4, ExpectedResult = true)]
        [TestCase(2014, 5, 5, ExpectedResult = false)]
        [TestCase(2014, 5, 5, ExpectedResult = false)]
        [TestCase(2014, 5, 6, ExpectedResult = true)]
        [TestCase(2014, 5, 7, ExpectedResult = false)]
        [TestCase(2015, 5, 3, ExpectedResult = false)]
        [TestCase(2015, 5, 4, ExpectedResult = true)]
        [TestCase(2015, 5, 5, ExpectedResult = false)]
        [TestCase(2016, 5, 3, ExpectedResult = false)]
        [TestCase(2016, 5, 4, ExpectedResult = true)]
        [TestCase(2016, 5, 5, ExpectedResult = false)]
        [TestCase(2017, 5, 3, ExpectedResult = false)]
        [TestCase(2017, 5, 4, ExpectedResult = true)]
        [TestCase(2017, 5, 5, ExpectedResult = false)]
        [TestCase(2018, 5, 3, ExpectedResult = false)]
        [TestCase(2018, 5, 4, ExpectedResult = true)]
        [TestCase(2018, 5, 5, ExpectedResult = false)]
        [TestCase(2019, 5, 3, ExpectedResult = false)]
        [TestCase(2019, 5, 4, ExpectedResult = true)]
        [TestCase(2019, 5, 5, ExpectedResult = false)]
        [TestCase(2020, 5, 3, ExpectedResult = false)]
        [TestCase(2020, 5, 4, ExpectedResult = true)]
        [TestCase(2020, 5, 5, ExpectedResult = false)]
        public bool IsGreeneryDay(int year, int month, int day)
        {
            return Japan.IsGreeneryDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 5, 4, ExpectedResult = false)]
        [TestCase(2010, 5, 5, ExpectedResult = true)]
        [TestCase(2010, 5, 6, ExpectedResult = false)]
        [TestCase(2011, 5, 4, ExpectedResult = false)]
        [TestCase(2011, 5, 5, ExpectedResult = true)]
        [TestCase(2011, 5, 6, ExpectedResult = false)]
        [TestCase(2012, 5, 4, ExpectedResult = false)]
        [TestCase(2012, 5, 5, ExpectedResult = true)]
        [TestCase(2012, 5, 6, ExpectedResult = false)]
        [TestCase(2013, 5, 4, ExpectedResult = false)]
        [TestCase(2013, 5, 5, ExpectedResult = true)]
        [TestCase(2013, 5, 6, ExpectedResult = true)]
        [TestCase(2013, 5, 7, ExpectedResult = false)]
        [TestCase(2014, 5, 4, ExpectedResult = false)]
        [TestCase(2014, 5, 5, ExpectedResult = true)]
        [TestCase(2014, 5, 6, ExpectedResult = false)]
        [TestCase(2015, 5, 4, ExpectedResult = false)]
        [TestCase(2015, 5, 5, ExpectedResult = true)]
        [TestCase(2015, 5, 6, ExpectedResult = false)]
        [TestCase(2016, 5, 4, ExpectedResult = false)]
        [TestCase(2016, 5, 5, ExpectedResult = true)]
        [TestCase(2016, 5, 6, ExpectedResult = false)]
        [TestCase(2017, 5, 4, ExpectedResult = false)]
        [TestCase(2017, 5, 5, ExpectedResult = true)]
        [TestCase(2017, 5, 6, ExpectedResult = false)]
        [TestCase(2018, 5, 4, ExpectedResult = false)]
        [TestCase(2018, 5, 5, ExpectedResult = true)]
        [TestCase(2018, 5, 6, ExpectedResult = false)]
        [TestCase(2019, 5, 4, ExpectedResult = false)]
        [TestCase(2019, 5, 5, ExpectedResult = true)]
        [TestCase(2019, 5, 6, ExpectedResult = true)]
        [TestCase(2019, 5, 7, ExpectedResult = false)]
        [TestCase(2020, 5, 4, ExpectedResult = false)]
        [TestCase(2020, 5, 5, ExpectedResult = true)]
        [TestCase(2020, 5, 6, ExpectedResult = false)]
        public bool IsChildrensDay(int year, int month, int day)
        {
            return Japan.IsChildrensDay(new DateTime(year, month, day));
        }
    }
}
