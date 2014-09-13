using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using FBApp.Exceptions;

namespace FBApp
{
    public class MusicYoutubePlaylistFeature
    {
        private YouTubeService m_YoutubeService;

        public MusicYoutubePlaylistFeature()
        {
            initYouTubeService();
        }

        private void initYouTubeService()
        {
            try
            {
                m_YoutubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyBkwI_LBAULBua9G5aE8uvuumL0XQQVppE",
                    ApplicationName = "FBApp"
                });
            }
            catch
            {
                throw new FacebookAppExceptions();
            }
        }

        public FacebookObjectCollection<Page> LoggedInUserMusic
        {
            get
            {
                return FacebookService.GetCollection<Page>("music"); 
            }
        }

        public string GetPlaylistURLFromYouTube(string i_Artist)
        {
            SearchListResponse searchResponse;
            SearchResource.ListRequest searchRequest = m_YoutubeService.Search.List("snippet");
            List<string> names = new List<string>();
            StringBuilder url = new StringBuilder("https://www.youtube.com/v/");

            searchRequest.Q = i_Artist;
            searchRequest.MaxResults = 10;
            searchRequest.Type = "video";
            searchResponse = searchRequest.Execute();
            url.Append(searchResponse.Items[0].Id.VideoId);
            searchRequest.Type = "playlist";
            searchResponse = searchRequest.Execute();
            if (searchResponse.Items.Count <= 0)
            {
                throw new Exception("No Available Playlists");
            }
            else
            {
                url.Append("&list=" + searchResponse.Items[0].Id.PlaylistId);
            }

            return url.ToString();
        }
    }
}