using System;

namespace FBApp.Patterns
{
    class BirthdayStrategy : IBirthdayFilterStrategy
    {
        public bool IsBirthdayNeeded(DateTime i_UserBirthday, BirthdayData i_Bdata)
        {
            bool result = true;
            if (i_UserBirthday == DateTime.Today)
            {
                i_Bdata.Date = FriendsBirthdays.BirthdaysDates.Today;
            }
            else if (i_UserBirthday == DateTime.Today.AddDays(1))
            {
                i_Bdata.Date = FriendsBirthdays.BirthdaysDates.Tomorrow;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}

