using System;
using System.Collections;
using System.Globalization;
using FacebookWrapper.ObjectModel;

namespace FBApp.Patterns
{
    public class BirthdaysFilter : IEnumerable
    {
        private readonly IBirthdayFilterStrategy rm_Strategy = null;

        public BirthdaysFilter(IBirthdayFilterStrategy i_Strategy)
        {
            rm_Strategy = i_Strategy;
        }

        public IEnumerator GetEnumerator()
        {
            DateTime i_Date = new DateTime();
            foreach (User fbUser in FacebookAppLogic.Instance.LoggedinUser.Friends)
            {
                BirthdayData bData;
                if (TryParseFriendBirthdayDateToSystemTime(ref i_Date, fbUser))
                {
                    bData = new BirthdayData();
                    if (rm_Strategy.IsBirthdayNeeded(i_Date, bData))
                    {
                        bData.Name = fbUser.Name;
                        yield return bData;
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
