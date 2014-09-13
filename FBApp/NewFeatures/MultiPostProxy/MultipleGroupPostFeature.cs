using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FBApp.NewFeatures.MultiPostProxy;

namespace FBApp
{
    public class MultipleGroupPostFeature : IMultiGroupsPost
    {
        private List<Group> m_LoggedInUserGroups;

        public MultipleGroupPostFeature(FacebookObjectCollection<Group> i_LoggedInUserGroups)
        {
            initUserGroups(i_LoggedInUserGroups);
        }

        public List<Group> LoggedInUserGroups
        {
            get
            {
                return m_LoggedInUserGroups;
            }
        }

        private void initUserGroups(FacebookObjectCollection<Group> i_LoggedInUserGroups)
        {
            m_LoggedInUserGroups = new List<Group>();

            foreach (Group group in i_LoggedInUserGroups)
            {
                LoggedInUserGroups.Add(group);
            }
        }

        public void SendPostToMultipleGroups(List<Group> i_SelectedGroups, string i_MessagePost)
        {
            foreach (Group group in i_SelectedGroups)
            {
                group.PostToWall(i_MessagePost);
            }
        }

        private Group findGroupByName(string i_GroupName)
        {
            Group matchingGroupByName = null;

            foreach (Group group in m_LoggedInUserGroups)
            {
                if (group.Name == i_GroupName)
                {
                    matchingGroupByName = group;
                    break;
                }
            }

            return matchingGroupByName;
        }
    }
}
