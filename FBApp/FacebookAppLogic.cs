using System;
using System.Collections.Generic;
using System.Threading;
using FBApp.NewFeatures;
using FBApp.Exceptions;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FBApp.NewFeatures.MultiPostProxy;

namespace FBApp
{
    public sealed class FacebookAppLogic
    {
        public static FacebookAppLogic Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new FacebookAppLogic();
                }

                return s_Instance;
            }
        }

        private static FacebookAppLogic s_Instance = null;

        public MusicYoutubePlaylistFeature MusicFeature { get; private set; }

        public IMultiGroupsPost MultiGroupsPost { get; private set; }

        public FacebookUserProfile UserProfile { get; private set; }

        public FacebookUserProfileCover UserProfileCover { get; private set; }

        public User LoggedinUser { get; private set; }

        public List<User> m_UserFriends = null;

        public List<User> LoggedInUserFriends
        {
            get
            {
                return fetchUserFriends();
            }
        }

        private FacebookAppLogic()
        {
        }

        // User login to facebook
        public bool TryUserLogin()
        {
            bool tryLoginResult;

            LoginResult result = FacebookService.Login(
                "192940970765612",
                "user_likes",
                "user_birthday",
                "friends_birthday",
                "publish_stream",
                "user_relationships",
                "user_relationship_details",
                "user_about_me",
                "user_status",
                "user_photos",
                "user_friends",
                "user_groups",
                "read_stream");

            if (string.IsNullOrEmpty(result.AccessToken))
            {
                tryLoginResult = false;
            }
            else
            {
                LoggedinUser = result.LoggedInUser;
                try
                {
                    MusicFeature = new MusicYoutubePlaylistFeature();
                    MultiGroupsPost = new MultiGroupFeatureProxy(LoggedinUser.Groups);
                    UserProfile = new FacebookUserProfile(LoggedinUser.Friends);
                    UserProfileCover = new FacebookUserProfileCover(LoggedinUser);
                    tryLoginResult = true;
                }
                catch (FacebookAppExceptions ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tryLoginResult;
        }

        private List<User> fetchUserFriends()
        {
            m_UserFriends = new List<User>();

            foreach (User friend in LoggedinUser.Friends)
            {
                m_UserFriends.Add(friend);
            }

            return m_UserFriends;
        }

        public string UserProfilePictureUrl
        {
            get
            {
                return LoggedinUser.PictureLargeURL;
            }
        }

        public void PostStatus(string i_PostMessage, string i_PrivacyPolicy)
        {
            LoggedinUser.PostStatus(i_PostMessage, i_PrivacyPolicy);
            UserProfileCover.LastStatus = i_PostMessage;
        }
    }
}
