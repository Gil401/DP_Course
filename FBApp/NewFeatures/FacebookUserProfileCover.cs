using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures
{
    public class FacebookUserProfileCover
    {
        public string ProfilePictureUrl { get; set; }

        public string LastStatus { get; set; }

        public string UserFullName { get; set; }

        public FacebookUserProfileCover(User i_LoggedInUser)
        {
            UserFullName = i_LoggedInUser.Name;
            ProfilePictureUrl = i_LoggedInUser.PictureLargeURL;
            if (i_LoggedInUser.Statuses.Count > 0)
            {
                LastStatus = i_LoggedInUser.Statuses[0].Message;
            }
        }
    }
}
