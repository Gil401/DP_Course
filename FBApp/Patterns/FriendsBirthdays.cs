using System;

namespace FBApp.Patterns
{
    public class FriendsBirthdays
    {
        private BirthdayData m_Bdays;

        public enum BirthdaysDates
        {
            Today, Tomorrow
        }

        public string TodayBirthdays
        {
            get
            {
                return fetchUpcomingBirthdates(BirthdaysDates.Today);
            }
        }

        public string TomorrowBirthdays
        {
            get
            {
                return fetchUpcomingBirthdates(BirthdaysDates.Tomorrow);
            }
        }

        private string fetchUpcomingBirthdates(BirthdaysDates i_BirthdaysDate)
        {
            string bDayString = "";


            return bDayString;
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
