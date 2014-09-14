using System;

namespace FBApp.Patterns
{
    class BirthdayStrategy : IBirthdayFilterStrategy
    {
        public bool IsBirthdayNeeded(DateTime i_UserBirthday, BirthdayData i_Bdata)
        {
            bool result = true;
            if ((DateTime.Now.Day == i_UserBirthday.Date.Day) && (DateTime.Now.Month == i_UserBirthday.Date.Month))
            {
                i_Bdata.Date = FriendsBirthdays.BirthdaysDates.Today;
            }
            else if ((DateTime.Now.AddDays(1).Day == i_UserBirthday.Date.Day) && (DateTime.Now.Month == i_UserBirthday.Date.Month))
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

