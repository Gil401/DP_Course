using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures
{
    public class FriendsBirthdayFacade
    {
        private FriendsBirthdays FriendsBirthdays { get; set; }

        public FriendsBirthdayFacade(FacebookObjectCollection<User> i_Friends)
        {
            FriendsBirthdays = new FriendsBirthdays(i_Friends);
        }

        public Dictionary<FriendsBirthdays.BirthdaysDates, string> Birthdays
        {
            get
            {
                return getTodayAndTommorrowBirthdays();
            }
        }

        private Dictionary<FriendsBirthdays.BirthdaysDates, string> getTodayAndTommorrowBirthdays()
        {
            Dictionary<FriendsBirthdays.BirthdaysDates, string> todayAndTomorrowBirthdays = new Dictionary<FriendsBirthdays.BirthdaysDates, string>();

            todayAndTomorrowBirthdays.Add(FriendsBirthdays.BirthdaysDates.Today, FriendsBirthdays.todayBirthdays);
            todayAndTomorrowBirthdays.Add(FriendsBirthdays.BirthdaysDates.Tomorrow, FriendsBirthdays.tomorrowBirthdays);

            return todayAndTomorrowBirthdays;
        }
    }
}
