using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Utilities;

namespace TPLibrary
{
    public class DatabaseClass
    {
        static DBConnect objDb = new DBConnect();
        static SqlCommand objCommand = new SqlCommand();

        public DataSet ReturnUsers()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPReturnUsers";
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet ReturnSecurityQuestion()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUserQuestions";
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet ReturnStateNames()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetStateProcedure1";
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public void InsertToUserDataTable(string fName, string Lname, string state, string address, string city,
            string email, string user, string pass, string question1, string answer1, string question2, string answer2, string question3, string answer3)
        {
            string FontColor = "Black";
            string BgColor = "white";
            string Font = "Courier";

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPInsertUsersToDatabase";

            SqlParameter insertParametr = new SqlParameter("@FirstName", fName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@LastName", Lname);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Username", user);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Password", pass);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@EmailAddress", email);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Address", address);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@City", city);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@State", state);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Question1", question1);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Answer1", answer1);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Question2", question2);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Answer2", answer2);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Question3", question3);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Answer3", answer3);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Font", Font);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@FontColor", FontColor);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@BgColor", BgColor);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@LoginSetting", "none");
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@PhotoPrivacy", "none");
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@ProfileInfoPrivacy", "none");
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@ContactPrivacy", "none");
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertUserPreferences(string font, string FontColor, string background, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUserUpdateFont";

            SqlParameter insertParametr = new SqlParameter("@Font", font);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@FontColor", FontColor);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@BgColor", background);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Username", username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);

        }


        public void InsertUserLoginSetting(string LoginSetting, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUpdateLoginSetting";

            SqlParameter insertParametr = new SqlParameter("@LoginSetting", LoginSetting);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Username", username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertUserPrivacySetting(string photo, string profile, string personalContact, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUpdatePrivacySetting";

            SqlParameter insertParametr = new SqlParameter("@Username", username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@PhotoPrivacy", photo);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@ProfilePrivacy", profile);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@ContactInfoPrivacy", personalContact);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertJob(string companyName, string position, string cityName, string description, int UserID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPAddCompanyInfo";

            SqlParameter insertParametr = new SqlParameter("@CompanyName", companyName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Position", position);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@CityName", cityName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Description", description);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@UserID", UserID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertSchool(string schoolName, DateTime DateStart, DateTime DateEnd, string SchoolDescription, string major, int UserID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPInsertSchool";

            SqlParameter insertParametr = new SqlParameter("@SchoolName", schoolName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@DateStart", DateStart);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Date;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@DateEnd", DateEnd);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Date;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@SchoolDescription", SchoolDescription);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Major", major);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@UserID", UserID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertAboutMe(string AboutMe, string FavoriteQoutes, string Hobbies, int UserId_FK)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPInserAboutMe";

            SqlParameter insertParametr = new SqlParameter("@AboutMe", AboutMe);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@FavoriteQoutes", FavoriteQoutes);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Hobbies", Hobbies);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@UserId_FK", UserId_FK);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertPicture(string photoName, int UserId_FK)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPPhotoInsert";

            SqlParameter insertParametr = new SqlParameter("@UserId", UserId_FK);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@CurrentPicture", photoName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void UpdatePicture(string photoName, int UserId_FK)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPPhotoUpdate";

            SqlParameter insertParametr = new SqlParameter("@UserId", UserId_FK);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@CurrentPicture", photoName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public DataSet ReturnPhotoNames()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPGetPictures";
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet ReturnJobs(int userID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPReturnjobs";

            SqlParameter insertParametr = new SqlParameter("@UserId", userID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet ReturnEducation(int userID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPReturnEducation";

            SqlParameter insertParametr = new SqlParameter("@UserID", userID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }


        public DataSet ReturnAbout(int userID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPReturnAbout";

            SqlParameter insertParametr = new SqlParameter("@UserID", userID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet ReturnAdvancedSearch(int userID, string hobby)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPAdvancedReturnSearch";

            SqlParameter insertParametr = new SqlParameter("@UserID", userID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Hobby", hobby);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet ReturnSearch(int userID, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPReturnSearch";

            SqlParameter insertParametr = new SqlParameter("@UserID", userID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@userName", username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public void InsertNewsFeed(string newsFeed, string username, DateTime inserted, string VideoURL, int UserId_FK)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPInsertNewsFeed";

            SqlParameter insertParametr = new SqlParameter("@NewsFeed", newsFeed);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);
            
            insertParametr = new SqlParameter("@UserName", username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@TimeAddIt", inserted);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.DateTime;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@VideoURL", VideoURL);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr); 
            
            insertParametr = new SqlParameter("@UserID_FK", UserId_FK);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public DataSet GetNewsFeed(int UserId_FK)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetNewsFeeds";

            SqlParameter insertParametr = new SqlParameter("@UserID", UserId_FK);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public DataSet GetFriendRequest(string Username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPGetRequests";

            SqlParameter insertParametr = new SqlParameter("@username", Username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public void SetFriendrequest(string Username, string MyUsername, int userId, string requestStatus)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TSetRequest";

            SqlParameter insertParametr = new SqlParameter("@username", Username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@myUsername", MyUsername);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@userRequestID", userId);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@requestStatus", @requestStatus);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void FriendUpdateRequest(int requestID, string requestStatus)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPStatusUpdate";

            SqlParameter insertParametr = new SqlParameter("@requestId", requestID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Status", requestStatus);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertBuddy(int UserId_FK, int FriendID, string BuddyUserName,  string Email)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPAddBuddy";

            SqlParameter insertParametr = new SqlParameter("@Myid", UserId_FK);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@FriendID", FriendID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);
          
            insertParametr = new SqlParameter("@BuddyUserName", BuddyUserName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            string Status = "OFFLINE";
            insertParametr = new SqlParameter("@Status", Status);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Email", Email);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public DataSet GetBuddyList(int MyID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPFillBuddyList";

            SqlParameter insertParametr = new SqlParameter("@MYUserID", MyID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public void UpdateUserStatus(string BuddyUserName, string status)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateMyOnlineStatus";

            SqlParameter insertParametr = new SqlParameter("@Username", BuddyUserName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Status", status);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public void InsertMessage(string MessageSend, string MessageReceived, int userSendID, int buddyUserId, DateTime sendMessage)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPInsertMessage";

            SqlParameter insertParametr = new SqlParameter("@MessageSend", MessageSend);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@MessageReceived", MessageReceived);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@UserSendID", userSendID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@UserReceivedID", buddyUserId);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@DateSend", sendMessage);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.DateTime;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        public DataSet GetMessegers(int UserSendID, int UserReceivedID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetMessages";

            SqlParameter insertParametr = new SqlParameter("@UserSendID", UserSendID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@UserReceivedID", UserReceivedID);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(insertParametr);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }
    }
}
