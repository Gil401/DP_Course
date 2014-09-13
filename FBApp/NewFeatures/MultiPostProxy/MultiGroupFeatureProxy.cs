using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FBApp.NewFeatures.MultiPostProxy
{
    // MultiGroupProxy send the message to the desired groups on a diffrent thread.
    // If the connection is lost it will try again until it succeeds.
    public class MultiGroupFeatureProxy : IMultiGroupsPost
    {
        private MultipleGroupPostFeature MultiGroupPost { get; set; }

        private Queue<MultiPostObject> MultiPostObjectsCache { get; set; }

        private Thread PostMessagesThread { get; set; }

        public List<Group> LoggedInUserGroups
        {
            get
            {
                return MultiGroupPost.LoggedInUserGroups;
            }
        }

        // Constructor - Init the real Multi Group Post Feature and init the cache Queue
        public MultiGroupFeatureProxy(FacebookObjectCollection<Group> i_LoggedInUserGroups)
        {
            MultiGroupPost = new MultipleGroupPostFeature(i_LoggedInUserGroups);
            MultiPostObjectsCache = new Queue<MultiPostObject>();
        }

        // Wrapper for the real Multi Group Post Feature function
        // Start the sending on a new Thread
        public void SendPostToMultipleGroups(List<Group> i_SelectedGroups, string i_MessagePost)
        {
            MultiPostObjectsCache.Enqueue(new MultiPostObject(i_SelectedGroups, i_MessagePost));

            if (PostMessagesThread == null || !PostMessagesThread.IsAlive)
            {
                PostMessagesThread = new Thread(new ThreadStart(sendMessagesToGroupsInTheBackground));
                PostMessagesThread.Start();
            }
        }

        // Send all the messages from the cahce.
        // It is possible that new messages will be added during sending
        private void sendMessagesToGroupsInTheBackground()
        {
            while (isThereMoreMessagesInCache())
            {
                bool tryToSend = true;
                MultiPostObject post = MultiPostObjectsCache.Dequeue();

                do
                {
                    try
                    {
                        tryToSend = false;
                        MultiGroupPost.SendPostToMultipleGroups(post.Groups, post.Message);
                    }
                    catch (WebExceptionWrapper)
                    {
                        tryToSend = true;
                    }
                } 
                while (tryToSend == true);
            }
        }

        private bool isThereMoreMessagesInCache()
        {
            return MultiPostObjectsCache.Count > 0;
        }
    }
}
