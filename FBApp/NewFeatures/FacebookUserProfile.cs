using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures
{
    public class FacebookUserProfile
    {
        public FacebookObjectCollection<User> Friends { get; private set; }

        public FacebookUserProfile(FacebookObjectCollection<User> i_Friends)
        {
            Friends = i_Friends;
        }
    }
}
