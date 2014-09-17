using System;
using System.Collections;
using System.Globalization;
using FacebookWrapper.ObjectModel;

namespace FBApp.Patterns
{
    public class BirthdaysFilter : IEnumerable
    {
        private BirthdayData m_BirthdayData;
        private IBirthdayFilterStrategy m_Strategy;

        public BirthdaysFilter(IBirthdayFilterStrategy i_Strategy)
        {
            m_Strategy = i_Strategy;
        }

        public IEnumerator GetEnumerator()
        {
            DateTime i_Date = new DateTime();

            foreach (User fbUser in FacebookAppLogic.Instance.LoggedinUser.Friends)
            {
                if (TryParseFriendBirthdayDateToSystemTime(ref i_Date, fbUser))
                {
                    m_BirthdayData = new BirthdayData();
                    if (m_Strategy.IsBirthdayNeeded(i_Date, m_BirthdayData))
                    {
                        m_BirthdayData.Name = fbUser.Name;
                        yield return (m_BirthdayData);
                    }
                }
            }
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
