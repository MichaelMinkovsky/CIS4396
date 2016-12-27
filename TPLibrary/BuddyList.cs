using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class BuddyList
    {
         

            int friendId;
            string currentPic;
            string username;
            string onlineStatus;
            string email;


        public int FriendID
        {
            get { return friendId; }
            set { friendId = value; }
        }

        public string CurrentPic
        {
            get { return currentPic; }
            set { currentPic = value; }
        }

        public string Username
        {
            get { return username; }
            set {username = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string OnlineStatus
        {
            get { return onlineStatus; }
            set { onlineStatus = value; }
    
         }


        public BuddyList() { }

        public BuddyList(int FriendId, string Pic, string UserName,string OnlineStatus, string Email)
        {
            friendId = FriendId;
            currentPic = Pic;
            username = UserName;
            onlineStatus = OnlineStatus;
            email = Email;
        }
    }
}
