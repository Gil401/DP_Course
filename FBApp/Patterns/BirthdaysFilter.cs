using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBApp.Patterns
{
    public class BirthdaysFilter : IEnumerable
    {

        private IBirthdayFilterStrategy m_Strategy = null;

        public BirthdaysFilter(IBirthdayFilterStrategy i_Strategy)
        {
            m_Strategy = i_Strategy;
        }

        public IEnumerator GetEnumerator()
        {
            DateTime i_Date = new DateTime();
            foreach (User fbUser in FacebookAppLogic.Instance.m_UserFriends)
            {
                BirthdayData bData;
                if (TryParseFriendBirthdayDateToSystemTime(ref i_Date, fbUser))
                {
                    bData = new BirthdayData();
                    if (m_Strategy.IsBirthdayNeeded(i_Date, bData))
                    {
                        bData.Name = fbUser.Name;
                        yield return (bData);
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
