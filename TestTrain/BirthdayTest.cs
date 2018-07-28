using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTrain
{
    [TestClass]
    public class BirthdayTest
    {
        [TestMethod]
        public void IsTodayNotJoeyBirthdayTest()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2018,07,28));

            Assert.AreEqual("No", holiday.IsTodayJoeyBirthday());
        }

        [TestMethod]
        public void IsTodayJoeyBirthdayTest()
        {
            var holiday = new FakeHoliday();
            holiday.SetToday(new DateTime(2018, 09, 01));

            Assert.AreEqual("Happy Birthday", holiday.IsTodayJoeyBirthday());
        }
    }

    public class FakeHoliday : Holiday
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