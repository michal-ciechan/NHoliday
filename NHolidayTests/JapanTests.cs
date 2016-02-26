using System;
using System.Collections.Generic;
using FluentAssertions;
using NHoliday;
using NUnit.Framework;

namespace NHolidayTests
{
    [TestFixture]
    public class JapanTests
    {
        [Test]
        public void ListPublicHolidays_2016()
        {
            var expected = new List<DateTime>
            {
                new DateTime(2016, 1, 01),
                new DateTime(2016, 1, 11),
                new DateTime(2016, 2, 11),
                new DateTime(2016, 3, 20),
                new DateTime(2016, 3, 21),
                new DateTime(2016, 4, 29),
                new DateTime(2016, 5, 03),
                new DateTime(2016, 5, 04),
                new DateTime(2016, 5, 05),
                new DateTime(2016, 7, 18),
                new DateTime(2016, 8, 11),
                new DateTime(2016, 9, 19),
                new DateTime(2016, 9, 22),
                new DateTime(2016, 10, 10),
                new DateTime(2016, 11, 03),
                new DateTime(2016, 11, 23),
                new DateTime(2016, 12, 23),
            };

            var res = Japan.ListPublicHolidays(2016);

            res.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ListPublicHolidays_2017()
        {
            var expected = new List<DateTime>
            {
                new DateTime(2017, 1, 01),
                new DateTime(2017, 1, 02),
                new DateTime(2017, 1, 09),
                new DateTime(2017, 2, 11),
                new DateTime(2017, 3, 20),
                new DateTime(2017, 4, 29),
                new DateTime(2017, 5, 03),
                new DateTime(2017, 5, 04),
                new DateTime(2017, 5, 05),
                new DateTime(2017, 7, 17),
                new DateTime(2017, 8, 11),
                new DateTime(2017, 9, 18),
                new DateTime(2017, 9, 23),
                new DateTime(2017, 10, 09),
                new DateTime(2017, 11, 03),
                new DateTime(2017, 11, 23),
                new DateTime(2017, 12, 23),
            };

            var res = Japan.ListPublicHolidays(2017);

            res.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ListBankHolidays_2016()
        {

            var expected = new List<DateTime>
            {
                new DateTime(2016, 1, 2),
                new DateTime(2016, 1, 3),
                new DateTime(2016, 12, 31),
            };

            var res = Japan.ListBankHolidays(2016);

            res.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ListBankHolidays_2017()
        {

            var expected = new List<DateTime>
            {
                new DateTime(2017, 1, 2),
                new DateTime(2017, 1, 3),
                new DateTime(2017, 12, 31),
            };

            var res = Japan.ListBankHolidays(2017);

            res.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ListHolidays_2016()
        {
            var expected = new List<DateTime>
            {
                new DateTime(2016, 1, 01),
                new DateTime(2016, 1, 02),
                new DateTime(2016, 1, 03),
                new DateTime(2016, 1, 11),
                new DateTime(2016, 2, 11),
                new DateTime(2016, 3, 20),
                new DateTime(2016, 3, 21),
                new DateTime(2016, 4, 29),
                new DateTime(2016, 5, 03),
                new DateTime(2016, 5, 04),
                new DateTime(2016, 5, 05),
                new DateTime(2016, 7, 18),
                new DateTime(2016, 8, 11),
                new DateTime(2016, 9, 19),
                new DateTime(2016, 9, 22),
                new DateTime(2016, 10, 10),
                new DateTime(2016, 11, 03),
                new DateTime(2016, 11, 23),
                new DateTime(2016, 12, 23),
                new DateTime(2016, 12, 31),
            };

            var res = Japan.ListHolidays(2016);

            res.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ListHolidays_2017()
        {
            var expected = new List<DateTime>()
            {
                new DateTime(2017, 1, 01),
                new DateTime(2017, 1, 02),
                new DateTime(2017, 1, 03),
                new DateTime(2017, 1, 09),
                new DateTime(2017, 2, 11),
                new DateTime(2017, 3, 20),
                new DateTime(2017, 4, 29),
                new DateTime(2017, 5, 03),
                new DateTime(2017, 5, 04),
                new DateTime(2017, 5, 05),
                new DateTime(2017, 7, 17),
                new DateTime(2017, 8, 11),
                new DateTime(2017, 9, 18),
                new DateTime(2017, 9, 23),
                new DateTime(2017, 10, 09),
                new DateTime(2017, 11, 03),
                new DateTime(2017, 11, 23),
                new DateTime(2017, 12, 23),
                new DateTime(2017, 12, 31),
            };

            var res = Japan.ListHolidays(2017);

            res.Should().BeEquivalentTo(expected);
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

        [Test]
        [TestCase(2010, 7, 18, ExpectedResult = false)]
        [TestCase(2010, 7, 19, ExpectedResult = true)]
        [TestCase(2010, 7, 20, ExpectedResult = false)]
        [TestCase(2011, 7, 17, ExpectedResult = false)]
        [TestCase(2011, 7, 18, ExpectedResult = true)]
        [TestCase(2011, 7, 19, ExpectedResult = false)]
        [TestCase(2012, 7, 15, ExpectedResult = false)]
        [TestCase(2012, 7, 16, ExpectedResult = true)]
        [TestCase(2012, 7, 17, ExpectedResult = false)]
        [TestCase(2013, 7, 14, ExpectedResult = false)]
        [TestCase(2013, 7, 15, ExpectedResult = true)]
        [TestCase(2013, 7, 16, ExpectedResult = false)]
        [TestCase(2014, 7, 20, ExpectedResult = false)]
        [TestCase(2014, 7, 21, ExpectedResult = true)]
        [TestCase(2014, 7, 22, ExpectedResult = false)]
        [TestCase(2015, 7, 19, ExpectedResult = false)]
        [TestCase(2015, 7, 20, ExpectedResult = true)]
        [TestCase(2015, 7, 21, ExpectedResult = false)]
        [TestCase(2016, 7, 17, ExpectedResult = false)]
        [TestCase(2016, 7, 18, ExpectedResult = true)]
        [TestCase(2016, 7, 19, ExpectedResult = false)]
        [TestCase(2017, 7, 16, ExpectedResult = false)]
        [TestCase(2017, 7, 17, ExpectedResult = true)]
        [TestCase(2017, 7, 18, ExpectedResult = false)]
        [TestCase(2018, 7, 15, ExpectedResult = false)]
        [TestCase(2018, 7, 16, ExpectedResult = true)]
        [TestCase(2018, 7, 17, ExpectedResult = false)]
        [TestCase(2019, 7, 14, ExpectedResult = false)]
        [TestCase(2019, 7, 15, ExpectedResult = true)]
        [TestCase(2019, 7, 16, ExpectedResult = false)]
        [TestCase(2020, 7, 19, ExpectedResult = false)]
        [TestCase(2020, 7, 20, ExpectedResult = true)]
        [TestCase(2020, 7, 21, ExpectedResult = false)]
        public bool IsSeaDay(int year, int month, int day)
        {
            return Japan.IsSeaDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2014, 8, 11, ExpectedResult = false)]
        [TestCase(2015, 8, 11, ExpectedResult = false)]
        [TestCase(2016, 8, 10, ExpectedResult = false)]
        [TestCase(2016, 8, 11, ExpectedResult = true)]
        [TestCase(2016, 8, 12, ExpectedResult = false)]
        [TestCase(2017, 8, 10, ExpectedResult = false)]
        [TestCase(2017, 8, 11, ExpectedResult = true)]
        [TestCase(2017, 8, 12, ExpectedResult = false)]
        [TestCase(2018, 8, 10, ExpectedResult = false)]
        [TestCase(2018, 8, 11, ExpectedResult = true)]
        [TestCase(2018, 8, 12, ExpectedResult = false)]
        [TestCase(2019, 8, 10, ExpectedResult = false)]
        [TestCase(2019, 8, 11, ExpectedResult = true)]
        [TestCase(2019, 8, 12, ExpectedResult = true)]
        [TestCase(2019, 8, 13, ExpectedResult = false)]
        [TestCase(2020, 8, 10, ExpectedResult = false)]
        [TestCase(2020, 8, 11, ExpectedResult = true)]
        [TestCase(2020, 8, 12, ExpectedResult = false)]
        public bool IsMountainDay(int year, int month, int day)
        {
            return Japan.IsMountainDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1965, 9, 15, ExpectedResult = false)]
        [TestCase(1966, 9, 14, ExpectedResult = false)]
        [TestCase(1966, 9, 15, ExpectedResult = true)]
        [TestCase(1966, 9, 16, ExpectedResult = false)]
        [TestCase(2000, 1, 15, ExpectedResult = false)]
        [TestCase(2000, 9, 14, ExpectedResult = false)]
        [TestCase(2000, 9, 15, ExpectedResult = true)]
        [TestCase(2000, 9, 16, ExpectedResult = false)]
        [TestCase(2001, 9, 14, ExpectedResult = false)]
        [TestCase(2001, 9, 15, ExpectedResult = true)]
        [TestCase(2001, 9, 16, ExpectedResult = false)]
        [TestCase(2002, 9, 14, ExpectedResult = false)]
        [TestCase(2002, 9, 15, ExpectedResult = true)]
        [TestCase(2002, 9, 16, ExpectedResult = true)]
        [TestCase(2002, 9, 17, ExpectedResult = false)]
        [TestCase(2003, 9, 14, ExpectedResult = false)]
        [TestCase(2003, 9, 15, ExpectedResult = true)]
        [TestCase(2003, 9, 16, ExpectedResult = false)]
        [TestCase(2004, 9, 19, ExpectedResult = false)]
        [TestCase(2004, 9, 20, ExpectedResult = true)]
        [TestCase(2004, 9, 21, ExpectedResult = false)]
        [TestCase(2005, 9, 18, ExpectedResult = false)]
        [TestCase(2005, 9, 19, ExpectedResult = true)]
        [TestCase(2005, 9, 20, ExpectedResult = false)]
        [TestCase(2006, 9, 17, ExpectedResult = false)]
        [TestCase(2006, 9, 18, ExpectedResult = true)]
        [TestCase(2006, 9, 19, ExpectedResult = false)]
        [TestCase(2007, 9, 16, ExpectedResult = false)]
        [TestCase(2007, 9, 17, ExpectedResult = true)]
        [TestCase(2007, 9, 18, ExpectedResult = false)]
        [TestCase(2008, 9, 14, ExpectedResult = false)]
        [TestCase(2008, 9, 15, ExpectedResult = true)]
        [TestCase(2008, 9, 16, ExpectedResult = false)]
        [TestCase(2009, 9, 20, ExpectedResult = false)]
        [TestCase(2009, 9, 21, ExpectedResult = true)]
        [TestCase(2009, 9, 22, ExpectedResult = false)]
        [TestCase(2010, 9, 19, ExpectedResult = false)]
        [TestCase(2010, 9, 20, ExpectedResult = true)]
        [TestCase(2010, 9, 21, ExpectedResult = false)]
        [TestCase(2011, 9, 18, ExpectedResult = false)]
        [TestCase(2011, 9, 19, ExpectedResult = true)]
        [TestCase(2011, 9, 20, ExpectedResult = false)]
        [TestCase(2012, 9, 16, ExpectedResult = false)]
        [TestCase(2012, 9, 17, ExpectedResult = true)]
        [TestCase(2012, 9, 18, ExpectedResult = false)]
        [TestCase(2013, 9, 15, ExpectedResult = false)]
        [TestCase(2013, 9, 16, ExpectedResult = true)]
        [TestCase(2013, 9, 17, ExpectedResult = false)]
        [TestCase(2014, 9, 14, ExpectedResult = false)]
        [TestCase(2014, 9, 15, ExpectedResult = true)]
        [TestCase(2014, 9, 16, ExpectedResult = false)]
        [TestCase(2015, 9, 20, ExpectedResult = false)]
        [TestCase(2015, 9, 21, ExpectedResult = true)]
        [TestCase(2015, 9, 22, ExpectedResult = false)]
        [TestCase(2016, 9, 18, ExpectedResult = false)]
        [TestCase(2016, 9, 19, ExpectedResult = true)]
        [TestCase(2016, 9, 20, ExpectedResult = false)]
        [TestCase(2017, 9, 17, ExpectedResult = false)]
        [TestCase(2017, 9, 18, ExpectedResult = true)]
        [TestCase(2017, 9, 19, ExpectedResult = false)]
        [TestCase(2018, 9, 16, ExpectedResult = false)]
        [TestCase(2018, 9, 17, ExpectedResult = true)]
        [TestCase(2018, 9, 18, ExpectedResult = false)]
        [TestCase(2019, 9, 15, ExpectedResult = false)]
        [TestCase(2019, 9, 16, ExpectedResult = true)]
        [TestCase(2019, 9, 17, ExpectedResult = false)]
        [TestCase(2020, 9, 20, ExpectedResult = false)]
        [TestCase(2020, 9, 21, ExpectedResult = true)]
        [TestCase(2020, 9, 22, ExpectedResult = false)]
        public bool IsRespectForTheAgedDay(int year, int month, int day)
        {
            return Japan.IsRespectForTheAgedDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1947, 9, 24, ExpectedResult = false)]
        [TestCase(1947, 9, 23, ExpectedResult = false)]
        [TestCase(1947, 9, 22, ExpectedResult = false)]
        [TestCase(1948, 9, 22, ExpectedResult = false)]
        [TestCase(1948, 9, 23, ExpectedResult = true)]
        [TestCase(1948, 9, 24, ExpectedResult = false)]
        [TestCase(2010, 9, 22, ExpectedResult = false)]
        [TestCase(2010, 9, 23, ExpectedResult = true)]
        [TestCase(2010, 9, 24, ExpectedResult = false)]
        [TestCase(2011, 9, 22, ExpectedResult = false)]
        [TestCase(2011, 9, 23, ExpectedResult = true)]
        [TestCase(2011, 9, 24, ExpectedResult = false)]
        [TestCase(2012, 9, 21, ExpectedResult = false)]
        [TestCase(2012, 9, 22, ExpectedResult = true)]
        [TestCase(2012, 9, 23, ExpectedResult = false)]
        [TestCase(2013, 9, 22, ExpectedResult = false)]
        [TestCase(2013, 9, 23, ExpectedResult = true)]
        [TestCase(2013, 9, 24, ExpectedResult = false)]
        [TestCase(2014, 9, 22, ExpectedResult = false)]
        [TestCase(2014, 9, 23, ExpectedResult = true)]
        [TestCase(2014, 9, 24, ExpectedResult = false)]
        [TestCase(2015, 9, 22, ExpectedResult = false)]
        [TestCase(2015, 9, 23, ExpectedResult = true)]
        [TestCase(2015, 9, 24, ExpectedResult = false)]
        [TestCase(2016, 9, 21, ExpectedResult = false)]
        [TestCase(2016, 9, 22, ExpectedResult = true)]
        [TestCase(2016, 9, 23, ExpectedResult = false)]
        [TestCase(2017, 9, 22, ExpectedResult = false)]
        [TestCase(2017, 9, 23, ExpectedResult = true)]
        [TestCase(2017, 9, 24, ExpectedResult = false)]
        [TestCase(2018, 9, 22, ExpectedResult = false)]
        [TestCase(2018, 9, 23, ExpectedResult = true)]
        [TestCase(2018, 9, 24, ExpectedResult = true)]
        [TestCase(2018, 9, 25, ExpectedResult = false)]
        [TestCase(2019, 9, 22, ExpectedResult = false)]
        [TestCase(2019, 9, 23, ExpectedResult = true)]
        [TestCase(2019, 9, 24, ExpectedResult = false)]
        [TestCase(2020, 9, 21, ExpectedResult = false)]
        [TestCase(2020, 9, 22, ExpectedResult = true)]
        [TestCase(2020, 9, 23, ExpectedResult = false)]
        public bool IsAutumnalEquinoxDay(int year, int month, int day)
        {
            return Japan.IsAutumnalEquinoxDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1965, 10, 9, ExpectedResult = false)]
        [TestCase(1965, 10, 10, ExpectedResult = false)]
        [TestCase(1965, 10, 11, ExpectedResult = false)]
        public bool IsSportsDay_Pre1966_False(int year, int month, int day)
        {
            return Japan.IsSportsDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2016, 9, 10, ExpectedResult = false)]
        [TestCase(2016, 11, 10, ExpectedResult = false)]
        public bool IsSportsDay_NonOctober_False(int year, int month, int day)
        {
            return Japan.IsSportsDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1993, 10, 9, ExpectedResult = false)]
        [TestCase(1993, 10, 10, ExpectedResult = true)]
        [TestCase(1993, 10, 11, ExpectedResult = true)]
        [TestCase(1993, 10, 12, ExpectedResult = false)]
        [TestCase(1994, 10, 9, ExpectedResult = false)]
        [TestCase(1994, 10, 10, ExpectedResult = true)]
        [TestCase(1994, 10, 11, ExpectedResult = false)]
        [TestCase(1995, 10, 9, ExpectedResult = false)]
        [TestCase(1995, 10, 10, ExpectedResult = true)]
        [TestCase(1995, 10, 11, ExpectedResult = false)]
        [TestCase(1996, 10, 9, ExpectedResult = false)]
        [TestCase(1996, 10, 10, ExpectedResult = true)]
        [TestCase(1996, 10, 11, ExpectedResult = false)]
        [TestCase(1997, 10, 9, ExpectedResult = false)]
        [TestCase(1997, 10, 10, ExpectedResult = true)]
        [TestCase(1997, 10, 11, ExpectedResult = false)]
        [TestCase(1998, 10, 9, ExpectedResult = false)]
        [TestCase(1998, 10, 10, ExpectedResult = true)]
        [TestCase(1998, 10, 11, ExpectedResult = false)]
        [TestCase(1999, 10, 9, ExpectedResult = false)]
        [TestCase(1999, 10, 10, ExpectedResult = true)]
        [TestCase(1999, 10, 11, ExpectedResult = true)]
        [TestCase(1999, 10, 12, ExpectedResult = false)]
        public bool IsSportsDay_Pre2000HappyMonday(int year, int month, int day)
        {
            return Japan.IsSportsDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2000, 10, 8, ExpectedResult = false)]
        [TestCase(2000, 10, 9, ExpectedResult = true)]
        [TestCase(2000, 10, 10, ExpectedResult = false)]
        [TestCase(2001, 10, 7, ExpectedResult = false)]
        [TestCase(2001, 10, 8, ExpectedResult = true)]
        [TestCase(2001, 10, 9, ExpectedResult = false)]
        [TestCase(2002, 10, 13, ExpectedResult = false)]
        [TestCase(2002, 10, 14, ExpectedResult = true)]
        [TestCase(2002, 10, 15, ExpectedResult = false)]
        [TestCase(2003, 10, 12, ExpectedResult = false)]
        [TestCase(2003, 10, 13, ExpectedResult = true)]
        [TestCase(2003, 10, 14, ExpectedResult = false)]
        [TestCase(2004, 10, 10, ExpectedResult = false)]
        [TestCase(2004, 10, 11, ExpectedResult = true)]
        [TestCase(2004, 10, 12, ExpectedResult = false)]
        [TestCase(2005, 10, 9, ExpectedResult = false)]
        [TestCase(2005, 10, 10, ExpectedResult = true)]
        [TestCase(2005, 10, 11, ExpectedResult = false)]
        [TestCase(2006, 10, 8, ExpectedResult = false)]
        [TestCase(2006, 10, 9, ExpectedResult = true)]
        [TestCase(2006, 10, 10, ExpectedResult = false)]
        [TestCase(2007, 10, 7, ExpectedResult = false)]
        [TestCase(2007, 10, 8, ExpectedResult = true)]
        [TestCase(2007, 10, 9, ExpectedResult = false)]
        [TestCase(2008, 10, 12, ExpectedResult = false)]
        [TestCase(2008, 10, 13, ExpectedResult = true)]
        [TestCase(2008, 10, 14, ExpectedResult = false)]
        [TestCase(2009, 10, 11, ExpectedResult = false)]
        [TestCase(2009, 10, 12, ExpectedResult = true)]
        [TestCase(2009, 10, 13, ExpectedResult = false)]
        [TestCase(2010, 10, 10, ExpectedResult = false)]
        [TestCase(2010, 10, 11, ExpectedResult = true)]
        [TestCase(2010, 10, 12, ExpectedResult = false)]
        [TestCase(2011, 10, 9, ExpectedResult = false)]
        [TestCase(2011, 10, 10, ExpectedResult = true)]
        [TestCase(2011, 10, 11, ExpectedResult = false)]
        [TestCase(2012, 10, 7, ExpectedResult = false)]
        [TestCase(2012, 10, 8, ExpectedResult = true)]
        [TestCase(2012, 10, 9, ExpectedResult = false)]
        [TestCase(2013, 10, 13, ExpectedResult = false)]
        [TestCase(2013, 10, 14, ExpectedResult = true)]
        [TestCase(2013, 10, 15, ExpectedResult = false)]
        [TestCase(2014, 10, 12, ExpectedResult = false)]
        [TestCase(2014, 10, 13, ExpectedResult = true)]
        [TestCase(2014, 10, 14, ExpectedResult = false)]
        [TestCase(2015, 10, 11, ExpectedResult = false)]
        [TestCase(2015, 10, 12, ExpectedResult = true)]
        [TestCase(2015, 10, 13, ExpectedResult = false)]
        [TestCase(2016, 10, 9, ExpectedResult = false)]
        [TestCase(2016, 10, 10, ExpectedResult = true)]
        [TestCase(2016, 10, 11, ExpectedResult = false)]
        [TestCase(2017, 10, 8, ExpectedResult = false)]
        [TestCase(2017, 10, 9, ExpectedResult = true)]
        [TestCase(2017, 10, 10, ExpectedResult = false)]
        [TestCase(2018, 10, 7, ExpectedResult = false)]
        [TestCase(2018, 10, 8, ExpectedResult = true)]
        [TestCase(2018, 10, 9, ExpectedResult = false)]
        [TestCase(2019, 10, 13, ExpectedResult = false)]
        [TestCase(2019, 10, 14, ExpectedResult = true)]
        [TestCase(2019, 10, 15, ExpectedResult = false)]
        [TestCase(2020, 10, 11, ExpectedResult = false)]
        [TestCase(2020, 10, 12, ExpectedResult = true)]
        [TestCase(2020, 10, 13, ExpectedResult = false)]
        public bool IsSportsDay(int year, int month, int day)
        {
            return Japan.IsSportsDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1866, 11, 3, ExpectedResult = false)]
        [TestCase(1867, 11, 3, ExpectedResult = false)]
        public bool IsCultureDay_Pre1868_False(int year, int month, int day)
        {
            return Japan.IsCultureDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2016, 10, 3, ExpectedResult = false)]
        [TestCase(2016, 12, 3, ExpectedResult = false)]
        public bool IsCultureDay_NonNovember_ReturnFalse(int year, int month, int day)
        {
            return Japan.IsCultureDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1868, 11, 2, ExpectedResult = false)]
        [TestCase(1868, 11, 3, ExpectedResult = true)]
        [TestCase(1868, 11, 4, ExpectedResult = false)]
        [TestCase(1869, 11, 2, ExpectedResult = false)]
        [TestCase(1869, 11, 3, ExpectedResult = true)]
        [TestCase(1869, 11, 4, ExpectedResult = false)]
        [TestCase(1870, 11, 2, ExpectedResult = false)]
        [TestCase(1870, 11, 3, ExpectedResult = true)]
        [TestCase(1870, 11, 4, ExpectedResult = false)]
        [TestCase(1871, 11, 2, ExpectedResult = false)]
        [TestCase(1871, 11, 3, ExpectedResult = true)]
        [TestCase(1871, 11, 4, ExpectedResult = false)]
        [TestCase(1872, 11, 2, ExpectedResult = false)]
        [TestCase(1872, 11, 3, ExpectedResult = true)]
        [TestCase(1872, 11, 4, ExpectedResult = true)]
        [TestCase(1872, 11, 5, ExpectedResult = false)]
        [TestCase(1911, 11, 2, ExpectedResult = false)]
        [TestCase(1911, 11, 3, ExpectedResult = true)]
        [TestCase(1911, 11, 4, ExpectedResult = false)]
        public bool IsCultureDay_Pre1912MeijisDeath(int year, int month, int day)
        {
            return Japan.IsCultureDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1912, 11, 3, ExpectedResult = false)]
        [TestCase(1913, 11, 3, ExpectedResult = false)]
        [TestCase(1914, 11, 3, ExpectedResult = false)]
        [TestCase(1915, 11, 3, ExpectedResult = false)]
        [TestCase(1916, 11, 3, ExpectedResult = false)]
        [TestCase(1917, 11, 3, ExpectedResult = false)]
        [TestCase(1918, 11, 3, ExpectedResult = false)]
        [TestCase(1919, 11, 3, ExpectedResult = false)]
        [TestCase(1920, 11, 3, ExpectedResult = false)]
        [TestCase(1921, 11, 3, ExpectedResult = false)]
        [TestCase(1922, 11, 3, ExpectedResult = false)]
        [TestCase(1923, 11, 3, ExpectedResult = false)]
        [TestCase(1924, 11, 3, ExpectedResult = false)]
        [TestCase(1925, 11, 3, ExpectedResult = false)]
        [TestCase(1926, 11, 3, ExpectedResult = false)]
        public bool IsCultureDay_Pre1927MeijiSetsu(int year, int month, int day)
        {
            return Japan.IsCultureDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1927, 11, 2, ExpectedResult = false)]
        [TestCase(1927, 11, 3, ExpectedResult = true)]
        [TestCase(1927, 11, 4, ExpectedResult = false)]
        [TestCase(1928, 11, 2, ExpectedResult = false)]
        [TestCase(1928, 11, 3, ExpectedResult = true)]
        [TestCase(1928, 11, 4, ExpectedResult = false)]
        [TestCase(1929, 11, 2, ExpectedResult = false)]
        [TestCase(1929, 11, 3, ExpectedResult = true)]
        [TestCase(1929, 11, 4, ExpectedResult = true)]
        [TestCase(1929, 11, 5, ExpectedResult = false)]
        [TestCase(1946, 11, 2, ExpectedResult = false)]
        [TestCase(1946, 11, 3, ExpectedResult = true)]
        [TestCase(1946, 11, 4, ExpectedResult = true)]
        [TestCase(1946, 11, 5, ExpectedResult = false)]
        [TestCase(1947, 11, 2, ExpectedResult = false)]
        [TestCase(1947, 11, 3, ExpectedResult = true)]
        [TestCase(1947, 11, 4, ExpectedResult = false)]
        public bool IsCultureDay_Pre1948_CultureDay(int year, int month, int day)
        {
            return Japan.IsCultureDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 11, 2, ExpectedResult = false)]
        [TestCase(2010, 11, 3, ExpectedResult = true)]
        [TestCase(2010, 11, 4, ExpectedResult = false)]
        [TestCase(2011, 11, 2, ExpectedResult = false)]
        [TestCase(2011, 11, 3, ExpectedResult = true)]
        [TestCase(2011, 11, 4, ExpectedResult = false)]
        [TestCase(2012, 11, 2, ExpectedResult = false)]
        [TestCase(2012, 11, 3, ExpectedResult = true)]
        [TestCase(2012, 11, 4, ExpectedResult = false)]
        [TestCase(2013, 11, 2, ExpectedResult = false)]
        [TestCase(2013, 11, 3, ExpectedResult = true)]
        [TestCase(2013, 11, 4, ExpectedResult = true)]
        [TestCase(2013, 11, 5, ExpectedResult = false)]
        [TestCase(2014, 11, 2, ExpectedResult = false)]
        [TestCase(2014, 11, 3, ExpectedResult = true)]
        [TestCase(2014, 11, 4, ExpectedResult = false)]
        [TestCase(2015, 11, 2, ExpectedResult = false)]
        [TestCase(2015, 11, 3, ExpectedResult = true)]
        [TestCase(2015, 11, 4, ExpectedResult = false)]
        [TestCase(2016, 11, 2, ExpectedResult = false)]
        [TestCase(2016, 11, 3, ExpectedResult = true)]
        [TestCase(2016, 11, 4, ExpectedResult = false)]
        [TestCase(2017, 11, 2, ExpectedResult = false)]
        [TestCase(2017, 11, 3, ExpectedResult = true)]
        [TestCase(2017, 11, 4, ExpectedResult = false)]
        [TestCase(2018, 11, 2, ExpectedResult = false)]
        [TestCase(2018, 11, 3, ExpectedResult = true)]
        [TestCase(2018, 11, 4, ExpectedResult = false)]
        [TestCase(2019, 11, 2, ExpectedResult = false)]
        [TestCase(2019, 11, 3, ExpectedResult = true)]
        [TestCase(2019, 11, 4, ExpectedResult = true)]
        [TestCase(2019, 11, 5, ExpectedResult = false)]
        [TestCase(2020, 11, 2, ExpectedResult = false)]
        [TestCase(2020, 11, 3, ExpectedResult = true)]
        [TestCase(2020, 11, 4, ExpectedResult = false)]
        public bool IsCultureDay_201x(int year, int month, int day)
        {
            return Japan.IsCultureDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1946, 11, 23, ExpectedResult = false)]
        [TestCase(1947, 11, 23, ExpectedResult = false)]
        public bool IsThanksgivingDay_Pre1948_False(int year, int month, int day)
        {
            return Japan.IsThanksgivingDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2016, 12, 23, ExpectedResult = false)]
        [TestCase(2016, 10, 23, ExpectedResult = false)]
        public bool IsThanksgivingDay_NonNovember_False(int year, int month, int day)
        {
            return Japan.IsThanksgivingDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1948, 11, 22, ExpectedResult = false)]
        [TestCase(1948, 11, 23, ExpectedResult = true)]
        [TestCase(1948, 11, 24, ExpectedResult = false)]
        [TestCase(1949, 11, 22, ExpectedResult = false)]
        [TestCase(1949, 11, 23, ExpectedResult = true)]
        [TestCase(1949, 11, 24, ExpectedResult = false)]
        public bool IsThanksgivingDay_Post1948(int year, int month, int day)
        {
            return Japan.IsThanksgivingDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 11, 22, ExpectedResult = false)]
        [TestCase(2010, 11, 23, ExpectedResult = true)]
        [TestCase(2010, 11, 24, ExpectedResult = false)]
        [TestCase(2011, 11, 22, ExpectedResult = false)]
        [TestCase(2011, 11, 23, ExpectedResult = true)]
        [TestCase(2011, 11, 24, ExpectedResult = false)]
        [TestCase(2012, 11, 22, ExpectedResult = false)]
        [TestCase(2012, 11, 23, ExpectedResult = true)]
        [TestCase(2012, 11, 24, ExpectedResult = false)]
        [TestCase(2013, 11, 22, ExpectedResult = false)]
        [TestCase(2013, 11, 23, ExpectedResult = true)]
        [TestCase(2013, 11, 24, ExpectedResult = false)]
        [TestCase(2014, 11, 22, ExpectedResult = false)]
        [TestCase(2014, 11, 23, ExpectedResult = true)]
        [TestCase(2014, 11, 24, ExpectedResult = true)]
        [TestCase(2014, 11, 25, ExpectedResult = false)]
        [TestCase(2015, 11, 22, ExpectedResult = false)]
        [TestCase(2015, 11, 23, ExpectedResult = true)]
        [TestCase(2015, 11, 24, ExpectedResult = false)]
        [TestCase(2016, 11, 22, ExpectedResult = false)]
        [TestCase(2016, 11, 23, ExpectedResult = true)]
        [TestCase(2016, 11, 24, ExpectedResult = false)]
        [TestCase(2017, 11, 22, ExpectedResult = false)]
        [TestCase(2017, 11, 23, ExpectedResult = true)]
        [TestCase(2017, 11, 24, ExpectedResult = false)]
        [TestCase(2018, 11, 22, ExpectedResult = false)]
        [TestCase(2018, 11, 23, ExpectedResult = true)]
        [TestCase(2018, 11, 24, ExpectedResult = false)]
        [TestCase(2019, 11, 22, ExpectedResult = false)]
        [TestCase(2019, 11, 23, ExpectedResult = true)]
        [TestCase(2019, 11, 24, ExpectedResult = false)]
        [TestCase(2020, 11, 22, ExpectedResult = false)]
        [TestCase(2020, 11, 23, ExpectedResult = true)]
        [TestCase(2020, 11, 24, ExpectedResult = false)]
        public bool IsThanksgivingDay_201x(int year, int month, int day)
        {
            return Japan.IsThanksgivingDay(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1987, 12, 23, ExpectedResult = false)]
        [TestCase(1988, 12, 23, ExpectedResult = false)]
        public bool IsEmporerAkihitosBirthday_Pre1989_False(int year, int month, int day)
        {
            return Japan.IsEmporerAkihitosBirthday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2016, 1, 23, ExpectedResult = false)]
        [TestCase(2016, 2, 23, ExpectedResult = false)]
        [TestCase(2016, 3, 23, ExpectedResult = false)]
        [TestCase(2016, 4, 23, ExpectedResult = false)]
        [TestCase(2016, 5, 23, ExpectedResult = false)]
        [TestCase(2016, 6, 23, ExpectedResult = false)]
        [TestCase(2016, 7, 23, ExpectedResult = false)]
        [TestCase(2016, 8, 23, ExpectedResult = false)]
        [TestCase(2016, 9, 23, ExpectedResult = false)]
        [TestCase(2016, 10, 23, ExpectedResult = false)]
        [TestCase(2016, 11, 23, ExpectedResult = false)]
        public bool IsEmporerAkihitosBirthday_NonDecember_False(int year, int month, int day)
        {
            return Japan.IsEmporerAkihitosBirthday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 12, 22, ExpectedResult = false)]
        [TestCase(2010, 12, 23, ExpectedResult = true)]
        [TestCase(2010, 12, 24, ExpectedResult = false)]
        [TestCase(2011, 12, 22, ExpectedResult = false)]
        [TestCase(2011, 12, 23, ExpectedResult = true)]
        [TestCase(2011, 12, 24, ExpectedResult = false)]
        [TestCase(2012, 12, 22, ExpectedResult = false)]
        [TestCase(2012, 12, 23, ExpectedResult = true)]
        [TestCase(2012, 12, 24, ExpectedResult = true)]
        [TestCase(2012, 12, 25, ExpectedResult = false)]
        [TestCase(2013, 12, 22, ExpectedResult = false)]
        [TestCase(2013, 12, 23, ExpectedResult = true)]
        [TestCase(2013, 12, 24, ExpectedResult = false)]
        [TestCase(2014, 12, 22, ExpectedResult = false)]
        [TestCase(2014, 12, 23, ExpectedResult = true)]
        [TestCase(2014, 12, 24, ExpectedResult = false)]
        [TestCase(2015, 12, 22, ExpectedResult = false)]
        [TestCase(2015, 12, 23, ExpectedResult = true)]
        [TestCase(2015, 12, 24, ExpectedResult = false)]
        [TestCase(2016, 12, 22, ExpectedResult = false)]
        [TestCase(2016, 12, 23, ExpectedResult = true)]
        [TestCase(2016, 12, 24, ExpectedResult = false)]
        [TestCase(2017, 12, 22, ExpectedResult = false)]
        [TestCase(2017, 12, 23, ExpectedResult = true)]
        [TestCase(2017, 12, 24, ExpectedResult = false)]
        [TestCase(2018, 12, 22, ExpectedResult = false)]
        [TestCase(2018, 12, 23, ExpectedResult = true)]
        [TestCase(2018, 12, 24, ExpectedResult = true)]
        [TestCase(2018, 12, 25, ExpectedResult = false)]
        [TestCase(2019, 12, 22, ExpectedResult = false)]
        [TestCase(2019, 12, 23, ExpectedResult = true)]
        [TestCase(2019, 12, 24, ExpectedResult = false)]
        [TestCase(2020, 12, 22, ExpectedResult = false)]
        [TestCase(2020, 12, 23, ExpectedResult = true)]
        [TestCase(2020, 12, 24, ExpectedResult = false)]
        public bool IsEmporerAkihitosBirthday_201x(int year, int month, int day)
        {
            return Japan.IsEmporerAkihitosBirthday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1990, 12, 31, ExpectedResult = false)]
        [TestCase(1991, 12, 31, ExpectedResult = false)]
        [TestCase(1992, 12, 31, ExpectedResult = false)]
        public bool IsDecemberBankHoliday_Pre1993_false(int year, int month, int day)
        {
            return Japan.IsDecemberBankHoliday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2016, 1, 3, ExpectedResult = false)]
        [TestCase(2016, 2, 3, ExpectedResult = false)]
        [TestCase(2016, 3, 3, ExpectedResult = false)]
        [TestCase(2016, 4, 3, ExpectedResult = false)]
        [TestCase(2016, 5, 3, ExpectedResult = false)]
        [TestCase(2016, 6, 3, ExpectedResult = false)]
        [TestCase(2016, 7, 3, ExpectedResult = false)]
        [TestCase(2016, 8, 3, ExpectedResult = false)]
        [TestCase(2016, 9, 3, ExpectedResult = false)]
        [TestCase(2016, 10, 3, ExpectedResult = false)]
        [TestCase(2016, 11, 3, ExpectedResult = false)]
        public bool IsDecemberBankHoliday_NonDecember_ReturnsFalse(int year, int month, int day)
        {
            return Japan.IsDecemberBankHoliday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1993, 12, 30, ExpectedResult = false)]
        [TestCase(1993, 12, 31, ExpectedResult = true)]
        [TestCase(1994, 12, 30, ExpectedResult = false)]
        [TestCase(1994, 12, 31, ExpectedResult = true)]
        [TestCase(1995, 12, 30, ExpectedResult = false)]
        [TestCase(1995, 12, 31, ExpectedResult = true)]
        [TestCase(1996, 12, 30, ExpectedResult = false)]
        [TestCase(1996, 12, 31, ExpectedResult = true)]
        [TestCase(1997, 12, 30, ExpectedResult = false)]
        [TestCase(1997, 12, 31, ExpectedResult = true)]
        [TestCase(1998, 12, 30, ExpectedResult = false)]
        [TestCase(1998, 12, 31, ExpectedResult = true)]
        [TestCase(1999, 12, 30, ExpectedResult = false)]
        [TestCase(1999, 12, 31, ExpectedResult = true)]
        public bool IsDecemberBankHoliday_Post1993(int year, int month, int day)
        {
            return Japan.IsDecemberBankHoliday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(2010, 12, 30, ExpectedResult = false)]
        [TestCase(2010, 12, 31, ExpectedResult = true)]
        [TestCase(2011, 12, 30, ExpectedResult = false)]
        [TestCase(2011, 12, 31, ExpectedResult = true)]
        [TestCase(2012, 12, 30, ExpectedResult = false)]
        [TestCase(2012, 12, 31, ExpectedResult = true)]
        [TestCase(2013, 12, 30, ExpectedResult = false)]
        [TestCase(2013, 12, 31, ExpectedResult = true)]
        [TestCase(2014, 12, 30, ExpectedResult = false)]
        [TestCase(2014, 12, 31, ExpectedResult = true)]
        [TestCase(2015, 12, 30, ExpectedResult = false)]
        [TestCase(2015, 12, 31, ExpectedResult = true)]
        [TestCase(2016, 12, 30, ExpectedResult = false)]
        [TestCase(2016, 12, 31, ExpectedResult = true)]
        [TestCase(2017, 12, 30, ExpectedResult = false)]
        [TestCase(2017, 12, 31, ExpectedResult = true)]
        [TestCase(2018, 12, 30, ExpectedResult = false)]
        [TestCase(2018, 12, 31, ExpectedResult = true)]
        [TestCase(2019, 12, 30, ExpectedResult = false)]
        [TestCase(2019, 12, 31, ExpectedResult = true)]
        [TestCase(2020, 12, 30, ExpectedResult = false)]
        [TestCase(2020, 12, 31, ExpectedResult = true)]
        public bool IsDecemberBankHoliday_201x(int year, int month, int day)
        {
            return Japan.IsDecemberBankHoliday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1990, 1, 2, ExpectedResult = false)]
        [TestCase(1990, 1, 3, ExpectedResult = false)]
        [TestCase(1991, 1, 2, ExpectedResult = false)]
        [TestCase(1991, 1, 3, ExpectedResult = false)]
        [TestCase(1992, 1, 2, ExpectedResult = false)]
        [TestCase(1992, 1, 3, ExpectedResult = false)]
        [TestCase(1993, 1, 2, ExpectedResult = false)]
        [TestCase(1993, 1, 3, ExpectedResult = false)]
        public bool IsJanuaryBankHoliday_Pre1994_ReturnsFalse(int year, int month, int day)
        {
            return Japan.IsJanuaryBankHoliday(new DateTime(year, month, day));
        }

        [Test]
        [TestCase(1994, 1, 1, ExpectedResult = false)]
        [TestCase(1994, 1, 2, ExpectedResult = true)]
        [TestCase(1994, 1, 3, ExpectedResult = true)]
        [TestCase(1994, 1, 4, ExpectedResult = false)]
        [TestCase(1995, 1, 1, ExpectedResult = false)]
        [TestCase(1995, 1, 2, ExpectedResult = true)]
        [TestCase(1995, 1, 3, ExpectedResult = true)]
        [TestCase(1995, 1, 4, ExpectedResult = false)]
        [TestCase(1996, 1, 1, ExpectedResult = false)]
        [TestCase(1996, 1, 2, ExpectedResult = true)]
        [TestCase(1996, 1, 3, ExpectedResult = true)]
        [TestCase(1996, 1, 4, ExpectedResult = false)]
        [TestCase(1997, 1, 1, ExpectedResult = false)]
        [TestCase(1997, 1, 2, ExpectedResult = true)]
        [TestCase(1997, 1, 3, ExpectedResult = true)]
        [TestCase(1997, 1, 4, ExpectedResult = false)]
        [TestCase(1998, 1, 1, ExpectedResult = false)]
        [TestCase(1998, 1, 2, ExpectedResult = true)]
        [TestCase(1998, 1, 3, ExpectedResult = true)]
        [TestCase(1998, 1, 4, ExpectedResult = false)]
        [TestCase(1999, 1, 1, ExpectedResult = false)]
        [TestCase(1999, 1, 2, ExpectedResult = true)]
        [TestCase(1999, 1, 3, ExpectedResult = true)]
        [TestCase(1999, 1, 4, ExpectedResult = false)]
        public bool IsJanuaryBankHoliday_Post1994(int year, int month, int day)
        {
            return Japan.IsJanuaryBankHoliday(new DateTime(year, month, day));
        }



        [Test]
        [TestCase(2010, 1, 1, ExpectedResult = false)]
        [TestCase(2010, 1, 2, ExpectedResult = true)]
        [TestCase(2010, 1, 3, ExpectedResult = true)]
        [TestCase(2010, 1, 4, ExpectedResult = false)]
        [TestCase(2011, 1, 1, ExpectedResult = false)]
        [TestCase(2011, 1, 2, ExpectedResult = true)]
        [TestCase(2011, 1, 3, ExpectedResult = true)]
        [TestCase(2011, 1, 4, ExpectedResult = false)]
        [TestCase(2012, 1, 1, ExpectedResult = false)]
        [TestCase(2012, 1, 2, ExpectedResult = true)]
        [TestCase(2012, 1, 3, ExpectedResult = true)]
        [TestCase(2012, 1, 4, ExpectedResult = false)]
        [TestCase(2013, 1, 1, ExpectedResult = false)]
        [TestCase(2013, 1, 2, ExpectedResult = true)]
        [TestCase(2013, 1, 3, ExpectedResult = true)]
        [TestCase(2013, 1, 4, ExpectedResult = false)]
        [TestCase(2014, 1, 1, ExpectedResult = false)]
        [TestCase(2014, 1, 2, ExpectedResult = true)]
        [TestCase(2014, 1, 3, ExpectedResult = true)]
        [TestCase(2014, 1, 4, ExpectedResult = false)]
        [TestCase(2015, 1, 1, ExpectedResult = false)]
        [TestCase(2015, 1, 2, ExpectedResult = true)]
        [TestCase(2015, 1, 3, ExpectedResult = true)]
        [TestCase(2015, 1, 4, ExpectedResult = false)]
        [TestCase(2016, 1, 1, ExpectedResult = false)]
        [TestCase(2016, 1, 2, ExpectedResult = true)]
        [TestCase(2016, 1, 3, ExpectedResult = true)]
        [TestCase(2016, 1, 4, ExpectedResult = false)]
        [TestCase(2017, 1, 1, ExpectedResult = false)]
        [TestCase(2017, 1, 2, ExpectedResult = true)]
        [TestCase(2017, 1, 3, ExpectedResult = true)]
        [TestCase(2017, 1, 4, ExpectedResult = false)]
        [TestCase(2018, 1, 1, ExpectedResult = false)]
        [TestCase(2018, 1, 2, ExpectedResult = true)]
        [TestCase(2018, 1, 3, ExpectedResult = true)]
        [TestCase(2018, 1, 4, ExpectedResult = false)]
        [TestCase(2019, 1, 1, ExpectedResult = false)]
        [TestCase(2019, 1, 2, ExpectedResult = true)]
        [TestCase(2019, 1, 3, ExpectedResult = true)]
        [TestCase(2019, 1, 4, ExpectedResult = false)]
        [TestCase(2020, 1, 1, ExpectedResult = false)]
        [TestCase(2020, 1, 2, ExpectedResult = true)]
        [TestCase(2020, 1, 3, ExpectedResult = true)]
        [TestCase(2020, 1, 4, ExpectedResult = false)]
        public bool IsJanuaryBankHoliday_201x(int year, int month, int day)
        {
            return Japan.IsJanuaryBankHoliday(new DateTime(year, month, day));
        }
    }
}
