using System;

namespace TestTrain
{
    public class Holiday
    {
        public string IsTodayJoeyBirthday()
        {
            var today = GetToday();

            if (today.Month == 9 && today.Day == 1)
            {
                return "Happy Birthday";
            }
            return "No";
        }

        internal virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}