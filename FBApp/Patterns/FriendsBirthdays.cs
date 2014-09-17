using System;

namespace FBApp.Patterns
{
    public class FriendsBirthdays
    {
        public enum BirthdaysDates
        {
            Today, Tomorrow
        }

        private bool isFriendBirthdayIsTomorrow(DateTime i_Date)
        {
            return DateTime.Now.AddDays(1).Day == i_Date.Date.Day && DateTime.Now.Month == i_Date.Date.Month;
        }

        private bool isFriendBirthdayToday(DateTime i_Date)
        {
            return (DateTime.Now.Day == i_Date.Date.Day) && (DateTime.Now.Month == i_Date.Date.Month);
        }
    }
}
