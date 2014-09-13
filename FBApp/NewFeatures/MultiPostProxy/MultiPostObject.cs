using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures.MultiPostProxy
{
    internal class MultiPostObject
    {
        public List<Group> Groups { get; private set; }

        public string Message { get; private set; }

        public MultiPostObject(List<Group> i_SelectedGroups, string i_Message)
        {
            Groups = i_SelectedGroups;
            Message = i_Message;
        }
    }
}
