using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures.MultiPostProxy
{
    public interface IMultiGroupsPost
    {
        void SendPostToMultipleGroups(List<Group> i_SelectedGroups, string i_MessagePost);

        List<Group> LoggedInUserGroups { get; }
    }
}
