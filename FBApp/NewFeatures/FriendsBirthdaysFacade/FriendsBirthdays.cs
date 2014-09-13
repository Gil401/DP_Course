using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures
{
    public class FriendsBirthdays
    {
        public enum BirthdaysDates
        {
            Today, Tomorrow
        }

        private FacebookObjectCollection<User> m_Friends;

        public FriendsBirthdays(FacebookObjectCollection<User> i_Friends)
        {
            m_Friends = i_Friends;
        }
        
        public string todayBirthdays
        {
            get
            {
                return fetchUpcomingBirthdates(BirthdaysDates.Today);
            }
        }

        public string tomorrowBirthdays
        {
            get
            {
                return fetchUpcomingBirthdates(BirthdaysDates.Tomorrow);
            }
        }

        private string fetchUpcomingBirthdates(BirthdaysDates i_BirthdaysDate)
        {
            DateTime date = new DateTime();
            string birthdays;

            try
            {
                switch (i_BirthdaysDate)
                {
                    case BirthdaysDates.Today:
                        birthdays = fetchUserFriendsTodayBirthdays(date);
                        break;
                    case BirthdaysDates.Tomorrow:
                        birthdays = fetchUserFriendsTomorrowBirthdays(date);
                        break;
                    default:
                        throw new Exception("Can't fetch birthdays");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return birthdays;
        }

        private string fetchUserFriendsTodayBirthdays(DateTime i_Date)
        {
            StringBuilder todayBirthdays = new StringBuilder();

            foreach (User friend in m_Friends)
            {
                try
                {
                    if (TryParseFriendBirthdayDateToSystemTime(ref i_Date, friend) && isFriendBirthdayToday(i_Date))
                    {
                        todayBirthdays.AppendLine(friend.Name);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return setBirthdaysMessage(todayBirthdays, "Today:");
        }

        private string fetchUserFriendsTomorrowBirthdays(DateTime i_Date)
        {
            StringBuilder tomorrowBirthdays = new StringBuilder();

            foreach (User friend in m_Friends)
            {
                try
                {
                    if (TryParseFriendBirthdayDateToSystemTime(ref i_Date, friend) && isFriendBirthdayIsTomorrow(i_Date))
                    {
                        tomorrowBirthdays.Append(friend.Name + ",  ");
                    }
                }
                catch (ArgumentException ex)
                {
                    throw ex;
                }
            }

            return setBirthdaysMessage(tomorrowBirthdays, "Tomorrow:");
        }

        private string setBirthdaysMessage(StringBuilder i_Birthdays, string i_BirthdayDateMessage)
        {
            string birthdays;

            if (i_Birthdays.Length > 0)
            {
                birthdays = string.Format(i_BirthdayDateMessage + Environment.NewLine + i_Birthdays.ToString());
            }
            else
            {
                birthdays = string.Format("{0} {1} No birthdays =[", i_BirthdayDateMessage, Environment.NewLine);
            }

            return birthdays;
        }

        private bool isFriendBirthdayIsTomorrow(DateTime i_Date)
        {
            return DateTime.Now.AddDays(1).Day == i_Date.Date.Day && DateTime.Now.Month == i_Date.Date.Month;
        }

        private bool isFriendBirthdayToday(DateTime i_Date)
        {
            return (DateTime.Now.Day == i_Date.Date.Day) && (DateTime.Now.Month == i_Date.Date.Month);
        }

        private bool TryParseFriendBirthdayDateToSystemTime(ref DateTime io_Date, User i_LoggedInUserFriend)
        {
            return DateTime.TryParseExact(
                i_LoggedInUserFriend.Birthday,
                "MM/dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out io_Date)
                || DateTime.TryParseExact(
                i_LoggedInUserFriend.Birthday,
                "MM/dd/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out io_Date);
        }
    }
}
