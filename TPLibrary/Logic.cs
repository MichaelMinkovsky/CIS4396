using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TPLibrary
{
    public class Logic
    {
        string emails;
        UserInfomation user;
        List<UserInfomation> newUserList = new List<UserInfomation>();
        SecurityQuestion questions;
        List<SecurityQuestion> listQuestion = new List<SecurityQuestion>();
        UserInfomation userSetting;
        List<UserInfomation> userSettings = new List<UserInfomation>();
        PhotoName photoName;
        List<PhotoName> newPhotoList = new List<PhotoName>();
        About newAbout;
        List<About> listAbout = new List<About>();
        NewsFeed newNewsFeed;
        List<NewsFeed> newslist = new List<NewsFeed>();
        BuddyList buddyList;
        List<BuddyList> buddyNames = new List<BuddyList>();

        public string Email
        {
            get { return emails; }
            set { emails = value; }
        }

        public List<BuddyList> BuddyNames
        {
            get { return buddyNames; }
        }


        public List<NewsFeed> NewsList
        {
            get { return newslist; }
        }

        public List<About> ListAbout
        {
            get { return listAbout; }
        }

        public List<PhotoName> NewPhotoList
        {
            get { return newPhotoList; }
        }


        public List<UserInfomation> NewUserList
        { 
         get{return newUserList;}
        }

        public List<UserInfomation> UserSettings
        {
            get { return userSettings; }
        }

        public List<SecurityQuestion> ListQuestion
        {
            get { return listQuestion; }
        }
        // Users methods

        public List<UserInfomation> CreatingObjectUsersFromDatabase(DataSet users)
        {
            DataTable Rest = users.Tables[0];
            for (int index = 0; index < Rest.Rows.Count; index++)
            {
                int ID = Convert.ToInt32(Rest.Rows[index]["UserID"].ToString());
                string FName = Rest.Rows[index]["FirstName"].ToString();
                string Lname = Rest.Rows[index]["LastName"].ToString();
                string username = Rest.Rows[index]["Username"].ToString();
                string password = Rest.Rows[index]["Password"].ToString();
                string email = Rest.Rows[index]["EmailAddress"].ToString();
                string address = Rest.Rows[index]["Address"].ToString();
                string city = Rest.Rows[index]["City"].ToString();
                string state = Rest.Rows[index]["State"].ToString();
                string question1 = Rest.Rows[index]["Question1"].ToString();
                string answer1 = Rest.Rows[index]["Answer1"].ToString();
                string question2 = Rest.Rows[index]["Question2"].ToString();
                string answer2 = Rest.Rows[index]["Answer2"].ToString();
                string question3 = Rest.Rows[index]["Question3"].ToString();
                string answer3 = Rest.Rows[index]["Answer3"].ToString();
                string font = Rest.Rows[index]["Font"].ToString();
                string fontColor = Rest.Rows[index]["FontColor"].ToString();
                string bgColor = Rest.Rows[index]["BgColor"].ToString();
                string photoPrivacy = Rest.Rows[index]["PhotoPrivacy"].ToString();
                string profileInfo = Rest.Rows[index]["ProfileInfoPrivacy"].ToString();
                string contactInfo = Rest.Rows[index]["ContactInfoPrivacy"].ToString();

                user = new UserInfomation(ID, FName, Lname, username, password, email, address, city, state, question1, answer1, question2, answer2, question3, answer3, font, fontColor, bgColor, photoPrivacy, profileInfo, contactInfo);
                newUserList.Add(user);
            }
           
            return newUserList;
        }

        public bool checkLogin (string username, string pass, List<UserInfomation> userList)
        {
            foreach (UserInfomation user in userList)
            {
                if (user.Username == username && user.Password == pass)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckUsername(string username, List<UserInfomation> userList) 
        {
            foreach (UserInfomation user in userList)
            {
                if (user.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public int GettingUserId(string username, List<UserInfomation> userList)
        {
            int Id;
            foreach (UserInfomation user in userList)
            {
                if (user.Username == username)
                {
                     Id = user.UserId;
                     return Id;
                }
            }
            return 0;

        }

        public string GettingUserEmail(string username, List<UserInfomation> userList)
        {
            string emailAddress;
            foreach (UserInfomation user in userList)
            {
                if (user.Username == username)
                {
                    emailAddress = user.EmailAddress;
                    return emailAddress;
                }
            }
            return "0";
        
        }

        public List<UserInfomation> getUserSetting(string username, List<UserInfomation> userList)
        {
            string font, fontColor, bgColor;
            
            foreach (UserInfomation user in userList)
            {
                if (user.Username == username)
                {
                    font = user.Font;
                    fontColor = user.FontColor;
                    bgColor = user.BgColor;
                    userSetting = new UserInfomation(font, fontColor, bgColor);
                    userSettings.Add(userSetting);
                }
            }

            return userSettings;
        }






        //security question methods
        public List<SecurityQuestion> CreatingSecurityQuestionObjectFromDatabase(DataSet users)
        {
            DataTable Rest = users.Tables[0];
            for (int index = 0; index < Rest.Rows.Count; index++)
            {
                string question = Rest.Rows[index]["Question"].ToString();
                questions = new SecurityQuestion(question);
                listQuestion.Add(questions);
            }


            return listQuestion;
        }

        public string RestorUsernamePassword(string question1, string answer1, string question2, string answer2, string question3, string answer3, List<UserInfomation> userList)
        {
            foreach (UserInfomation user in userList)
            {
                if ((user.Question1 == question1 && user.Answer1 == answer1) && (user.Question2 == question2 && user.Answer2 == answer2) && (user.Question3 == question3 && user.Answer3 == answer3))
                {
                    string password = user.Password;
                    string userName = user.Username;
                    string forgotten = "Your username " +  userName + " your password " + password.ToString();
                    return forgotten;
                }
            }
            string none = "no username and password found with your combination";
            return none;
        }

        //PicturePreferences


        public string returnString(DataSet newData, int userID)
        {
            string photoname;
            DataTable Rest = newData.Tables[0];
            for (int index = 0; index < Rest.Rows.Count; index++)
            {
                int ID = Convert.ToInt32(Rest.Rows[index]["UserId"].ToString());
                string CurrentPicture = Rest.Rows[index]["CurrentPicture"].ToString();

                photoName = new PhotoName(CurrentPicture, ID);
                NewPhotoList.Add(photoName);
            }

            return photoname = findPhotoName(NewPhotoList, userID);
        }

        public string findPhotoName(List<PhotoName> photos, int userID)
        {
            string photoname;
            foreach (PhotoName name in photos)
            {
                if (name.UserID == userID)
                {
                    return photoname = name.CurrentPhoto;
                }
            }

            return "-1";
        }
       

        //video links
        public List<NewsFeed> ReturnNewsFeed(DataSet newSet)
        {
            DataTable Rest = newSet.Tables[0];
            for (int index = 0; index < Rest.Rows.Count; index++)
            {
                string newsFeed = Rest.Rows[index]["NewsFeed"].ToString();
                string UserNames = Rest.Rows[index]["UserName"].ToString();
                string VideoURLs = Rest.Rows[index]["VideoURL"].ToString();

                newNewsFeed = new NewsFeed(newsFeed, UserNames, VideoURLs);
                newslist.Add(newNewsFeed);
            }
            return newslist;
        }

        public string ReturnVideoLink(string url, List<NewsFeed> list)
        {
            string URL;
            foreach (NewsFeed news in list)
            {
                if (news.VideoURL == url)
                {
                    return URL = news.VideoURL;
                }
            }
            return URL = "-1";
        }


        //buddyStuf


        public List<BuddyList> CreatingObjectBuddysFromDatabase(DataSet users)
        {
            //FriendID_FK, CurrentPicture, BuddyUserName, OnlineStatus, EmailAddress
            DataTable Rest = users.Tables[0];
            for (int index = 0; index < Rest.Rows.Count; index++)
            {
                int ID = Convert.ToInt32(Rest.Rows[index]["FriendID_FK"].ToString());
                string CurrentPic = Rest.Rows[index]["CurrentPicture"].ToString();
                string buddyName = Rest.Rows[index]["BuddyUserName"].ToString();
                string status = Rest.Rows[index]["OnlineStatus"].ToString();
                string email = Rest.Rows[index]["EmailAddress"].ToString();
               
                buddyList = new BuddyList(ID, CurrentPic, buddyName, status, email);
                buddyNames.Add(buddyList);

            }
            return buddyNames;
        }

        public string getemails(List<BuddyList> newlist)
        {
            
            foreach (BuddyList user in newlist)
            {
                emails += user.Email + "," ;
            }
            return emails;
        }
    }
}
