using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTrain
{
    [TestClass]
    public class HolidayTest
    {
        private FakeHoliday _fakeHoliday;

        [TestInitialize]
        public void SetUp()
        {
            _fakeHoliday = new FakeHoliday();
        }

        private void ShouldBe(string expected)
        {
            Assert.AreEqual(expected, _fakeHoliday.IsTodayJoeyBirthday());
        }

        private void GivenDate(int year,int month,int day)
        {
            _fakeHoliday.SetToday(new DateTime(year, month, day));
        }

        [TestMethod]
        public void IsTodayNotJoeyBirthdayTest()
        {
            GivenDate(2018, 07, 28);
            ShouldBe("No");
        }

        [TestMethod]
        public void IsTodayJoeyBirthdayTest()
        {
            GivenDate(2018, 09, 01);
            ShouldBe("Happy Birthday"); 
        }
    }

    internal class FakeHoliday : Holiday
    {
        private DateTime _today;
        internal override DateTime GetToday()
        {
            return _today;
        }

        internal void SetToday(DateTime date)
        {
            _today = date;
        }
    }
}