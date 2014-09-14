using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FBApp.Patterns;
using FriendsBirthdays = FBApp.NewFeatures.FriendsBirthdays;

namespace FBApp
{
    public partial class FacebookAppForm : Form
    {
        private const int k_LastItem = 0;

        public FacebookAppForm()
        {
            InitializeComponent();
            initLoggedInUserProfileCover();
            initLoggedInUserProfile();
            new Thread(initMultiGroupsPostFeature).Start();
            new Thread(initMusicFeature).Start();
        }

        private void initLoggedInUserProfileCover()
        {
            labelName.Text = FacebookAppLogic.Instance.UserProfileCover.UserFullName;
            pictureBoxProfilePicture.LoadAsync(FacebookAppLogic.Instance.UserProfileCover.ProfilePictureUrl);
            if (FacebookAppLogic.Instance.UserProfileCover.LastStatus == null)
            {
                labelMyStatus.Text = string.Empty;
            }
            else
            {
                labelMyStatus.Text = FacebookAppLogic.Instance.UserProfileCover.LastStatus;
            }
        }

        private void initLoggedInUserProfile()
        {
            StringBuilder todayBday = new StringBuilder();
            StringBuilder tomorrowBday = new StringBuilder();
            new Thread(initListBoxFriends).Start();
            BirthdaysFilter relevantBirthdays = new BirthdaysFilter(new BirthdayStrategy());
            labelFriendStatus.MaximumSize = new Size(700, 0);
            labelFriendStatus.AutoSize = true;
            
            foreach (BirthdayData bData in relevantBirthdays)
            {
                if (bData.Date.Equals(FriendsBirthdays.BirthdaysDates.Today))
                {
                    todayBday.AppendLine(bData.Name);
                }
                else
                {
                    tomorrowBday.AppendLine(bData.Name);
                }
            }

            lableTodayBirthdays.Text = setBirthdaysMessage(todayBday, "Today: ");
            lableTomorrowBirthdays.Text = setBirthdaysMessage(tomorrowBday, "Tomorrow: ");
            this.comboBoxPrivacy.SelectedIndex = k_LastItem;
        }

        private void initMusicFeature()
        {
            FacebookObjectCollection<Page> LoggedInUserMusic = FacebookAppLogic.Instance.MusicFeature.LoggedInUserMusic;

            if (!listBoxMusic.InvokeRequired)
            {
                pageBindingSource.DataSource = LoggedInUserMusic;
            }
            else
            {
                listBoxMusic.Invoke(new Action(() => pageBindingSource.DataSource = LoggedInUserMusic));
            }

            listBoxMusic.SelectionMode = SelectionMode.One;
        }

        private void initMultiGroupsPostFeature()
        {
            List<Group> groupsCollection = FacebookAppLogic.Instance.MultiGroupsPost.LoggedInUserGroups;

            try
            {
                if (!groupsBox.InvokeRequired)
                {
                    loggedInUserGroupsBindingSource.DataSource = groupsCollection;
                }
                else
                {
                    groupsBox.Invoke(new Action(() => loggedInUserGroupsBindingSource.DataSource = groupsCollection));
                }

                groupsBox.SelectionMode = SelectionMode.MultiSimple;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void initListBoxFriends()
        {
            var allFriends = FacebookAppLogic.Instance.LoggedinUser.Friends;

            if (!listBoxFriends.InvokeRequired)
            {
                friendListBindingSource.DataSource = allFriends;
            }
            else
            {
                listBoxFriends.Invoke(new Action(() => friendListBindingSource.DataSource = allFriends));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string privacy = string.Empty;
            switch (comboBoxPrivacy.SelectedIndex)
            {
                case 0:
                    privacy = "{'value':'SELF'}";
                    break;
                case 1:
                    privacy = "{'value':'ALL_FRIENDS'}";
                    break;
                case 2:
                    privacy = "{'value':'EVERYONE'}";
                    break;
                default:
                    break;
            }

            try
            {
                FacebookAppLogic.Instance.LoggedinUser.PostStatus(textBoxStatus.Text, privacy);
                labelMyStatus.Text = FacebookAppLogic.Instance.UserProfileCover.LastStatus;
                MessageBox.Show("Post successfuly sent ", null, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxStatus.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private User fetchSelectedUser()
        {
            User user;

            if (listBoxFriends.InvokeRequired)
            {
                user = (User)listBoxFriends.Invoke(new Func<User>(() => fetchSelectedUser()));
            }
            else
            {
                if (listBoxFriends.SelectedItem != null)
                {
                    user = listBoxFriends.SelectedItem as User;
                }
                else
                {
                    user = null;
                }
            }

            return user;
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            buttonPost.Enabled = !string.IsNullOrEmpty(this.textBoxStatus.Text);
        }

        private void fetchSelectedUserDetails(User i_SelectedUsert)
        {
            string details = string.Format(
                    @"
Full Name: {0}
Gender: {1}
Relationship status: {2}
Birthday: {3}",
                    i_SelectedUsert.Name,
                    i_SelectedUsert.Gender,
                    i_SelectedUsert.RelationshipStatus.GetValueOrDefault(),
                    i_SelectedUsert.Birthday);
            if (!labelFullFriendDetails.InvokeRequired)
            {
                labelFullFriendDetails.Text = details;
            }
            else
            {
                labelFullFriendDetails.Invoke(new Action(() => labelFullFriendDetails.Text = details));
            }
        }

        private void fetchUserDetails()
        {
            User selectedUser = fetchSelectedUser();

            if (selectedUser != null)
            {
                pictureBoxSelectedFriend.LoadAsync(selectedUser.PictureLargeURL);
                fetchSelectedUserDetails(selectedUser);
                fetchSelectedUserStatus(selectedUser);
            }
        }

        private void fetchSelectedUserStatus(User selectedUser)
        {
            string friendStatus;

            if (selectedUser.Statuses.Count > 0)
            {
                friendStatus = selectedUser.Statuses[k_LastItem].Message;
            }
            else
            {
                friendStatus = string.Empty;
            }

            if (!labelFriendStatus.InvokeRequired)
            {
                labelFriendStatus.Text = friendStatus;
            }
            else
            {
                labelFriendStatus.Invoke(new Action(() => labelFriendStatus.Text = friendStatus));
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(fetchUserDetails).Start();
        }

        private void buttonPostToGroups_Click(object sender, EventArgs e)
        {
            string groupsPostText = textBoxGroupsPost.Text;
            List<string> groupsNames = new List<string>();
            List<Group> groups = new List<Group>();

            foreach (Group group in groupsBox.SelectedItems)
            {
                groups.Add(group);
            }

            FacebookAppLogic.Instance.MultiGroupsPost.SendPostToMultipleGroups(groups, textBoxGroupsPost.Text);
            textBoxGroupsPost.Text = string.Empty;
            groupsBox.ClearSelected();
        }

        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string artistSelected = listBoxMusic.GetItemText(listBoxMusic.SelectedItem);

            try
            {
                string artistName = FacebookAppLogic.Instance.MusicFeature.GetPlaylistURLFromYouTube(artistSelected);
                axShockwaveFlashPlayer.Movie = artistName;
                labelNoPlaylists.Visible = false;
                axShockwaveFlashPlayer.Show();
                axShockwaveFlashPlayer.Play();
            }
            catch
            {
                axShockwaveFlashPlayer.Visible = false;
                labelNoPlaylists.Visible = true;
            }
        }

        private void textBoxGroupsPost_TextChanged(object sender, EventArgs e)
        {
            buttonPostToGoups.Enabled = !string.IsNullOrEmpty(this.textBoxGroupsPost.Text) &&
                                         groupsBox.SelectedItems.Count > 0;
        }

        private void groupsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPostToGoups.Enabled = !string.IsNullOrEmpty(this.textBoxGroupsPost.Text) &&
                                         groupsBox.SelectedItems.Count > 0;
        }
    }
}
