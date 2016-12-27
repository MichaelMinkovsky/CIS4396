using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class NewsFeed
    {
        int id;
        string newsfeed;
        DateTime timeAddit;
        string videoURL;
        string userName;

        public int ID
        { 
            get{return id;}
            set { id = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string VideoURL
        {
            get { return videoURL; }
            set { videoURL = value; }
        }

        public string NewsFeeds
        {
            get { return newsfeed; }
            set { newsfeed = value; }
        }

        public DateTime TimeAddIt
        {
            get { return timeAddit; }
            set { timeAddit = value; }
        }

        public NewsFeed() { }

        public NewsFeed(int ID, string NewsFeeds, DateTime TimeAddIt, string VideoURL)
        {
            id = ID;
            newsfeed = NewsFeeds;
            timeAddit = TimeAddIt;
            videoURL = VideoURL;
        }

        public NewsFeed(string NewsFeeds, string UserName, string VideoURL)
        {
            newsfeed = NewsFeeds;
            userName = UserName;
            videoURL = VideoURL;
        }
    }
}
