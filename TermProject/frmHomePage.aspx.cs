using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Drawing;
using TPLibrary;

namespace TermProject
{
    public partial class frmHomePage : System.Web.UI.Page
    {
        TPLibrary.DatabaseClass newDb = new TPLibrary.DatabaseClass();
        TPLibrary.Logic newLogic = new TPLibrary.Logic();
        DataSet newSet = new DataSet();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (HF.Value == "true")
            {
                txtMessage.Visible = true;
                btnSendMessage.Visible = true; ;
            }
            else
            {
                txtMessage.Visible = false;
                btnSendMessage.Visible = false;
            }

            if (Request.Cookies["Login"] == null)
            {
                Response.Redirect("frmLogin.aspx");
            }
            if (!IsPostBack)
            {
                HFfield.Value = "false";
            }
            txtAdvancedSearch.Visible = false;
            IBadvanced.Visible = false;
            string Username = (string)Session["Username"];
            txtUsername.InnerText = " " + Username;
            getUserSetting();
            int id = (int)Session["ID"];
            DataSet newSet = newDb.ReturnPhotoNames();
            string fileName = newLogic.returnString(newSet, id);
            if (fileName != "-1")
            { ImgUrl.ImageUrl = fileName; }
            CreateJobsGV();
            CreateEducation();
            CreatingAbout();
            createNewsFeed();
            LoadBuddylist();
            
        }

        public void getUserSetting()
        {
            string Username = (string)Session["Username"];
            List<UserInfomation> newList, userSettings;
            newList = (List<UserInfomation>)Session["UserList"];
            userSettings = newLogic.getUserSetting(Username, newList);

            foreach (UserInfomation user in userSettings)
            {

                bdBody.Attributes.Add("style", "Color: " + user.FontColor + ";" + "background:" + user.BgColor + ";" + "font-family: " + user.Font);
            }
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmUserSettings.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            string myUsername = (string)Session["Username"];
            string status = "OFFLINE";
            newDb.UpdateUserStatus(myUsername, status);
            WriteCookie();
            Server.Transfer("frmLogin.aspx");
        }

        public void WriteCookie()
        {
            string userName = (string)Session["Username"];
            HttpCookie myCookie = new HttpCookie("Login");
            myCookie.Values["Name"] = "";
            myCookie.Expires = new DateTime(2000, 1, 1);
            Response.Cookies.Add(myCookie);
        }

        protected void btnPersonalInform(object sender, EventArgs e)
        {
            Server.Transfer("frmProfileInfo.aspx");
        }

        protected void ImgUrl_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmProfileInfo.aspx");
        }

        public void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            gvMesseger.Visible = false;
            gvFriendRequest.Visible = false;
            btnSubmitNewsFeed.Visible = false;
            txtInput.Visible = false;
            txtVideoUrl.Visible = false;
            gvNewsFeed.Visible = false;
            gvSearch.Visible = true;
            gvAdvancedSearch.Visible = false;
            int id = (int)Session["ID"];
            if (txtSearch.Text != "")
            {
                DataSet newSet;
                newSet = newDb.ReturnSearch(id, txtSearch.Text);
                gvSearch.DataSource = newSet;
                gvSearch.DataBind();
                int count = gvSearch.Rows.Count;
                if (count == 0)
                { Response.Write("<script>alert('Could not return anything relevant to your search');</script>"); }
            }
            else { Response.Write("<script>alert('Search box can not be empty');</script>"); }

        }

        public void CreateJobsGV()
        {
            int id = (int)Session["ID"];
            gvJobs.DataSource = newDb.ReturnJobs(id);
            gvJobs.DataBind();
        }

        public void CreateEducation()
        {
            int id = (int)Session["ID"];
            gvEducation.DataSource = newDb.ReturnEducation(id);
            gvEducation.DataBind();
        }

        public void CreatingAbout()
        {
            int id = (int)Session["ID"];
            gvAbout.DataSource = newDb.ReturnAbout(id);
            gvAbout.DataBind();
        }

        protected void IBadvanced_Click(object sender, ImageClickEventArgs e)
        {
            gvMesseger.Visible = false;
            gvFriendRequest.Visible = false;
            btnSubmitNewsFeed.Visible = false;
            txtInput.Visible = false;
            txtVideoUrl.Visible = false;
            gvNewsFeed.Visible = false;
            gvSearch.Visible = false;
            gvAdvancedSearch.Visible = true;
            int id = (int)Session["ID"];
            if (txtAdvancedSearch.Text != "")
            {
                DataSet newSet;
                newSet = newDb.ReturnAdvancedSearch(id, txtAdvancedSearch.Text);
                gvAdvancedSearch.DataSource = newSet;
                gvAdvancedSearch.DataBind();
                int count = gvAdvancedSearch.Rows.Count;
                if (count == 0)
                { Response.Write("<script>alert('Could not return anything relevant to your search');</script>"); }
            }
            else { Response.Write("<script>alert('Search box can not be empty');</script>"); }
        }

        public void createNewsFeed()
        {
            gvFriendRequest.Visible = false;
            gvSearch.Visible = false;
            btnSubmitNewsFeed.Visible = true;
            txtInput.Visible = true;
            txtVideoUrl.Visible = true;
            gvNewsFeed.Visible = false;
            gvAdvancedSearch.Visible = false;
            int id = (int)Session["ID"];
            gvNewsFeed.Visible = true;
            DataSet newSet;
            newSet = newDb.GetNewsFeed(id);
            Session["newsfeed"] = newSet;
            gvNewsFeed.DataSource = newSet;
            gvNewsFeed.DataBind();

        }

        protected void btnSubmitNewsFeed_Click(object sender, EventArgs e)
        {
            int id = (int)Session["ID"];
            string Username = (string)Session["Username"];
            string URL;
            List<UserInfomation> newList;
            List<BuddyList> buddyList;
            
            if (txtInput.Text != "")
            {
                URL = txtVideoUrl.Text;
                string newsfeed = txtInput.Text;
                DateTime today = DateTime.Now;
                newDb.InsertNewsFeed(newsfeed, Username, today, URL, id);
                txtInput.Text = "";
                createNewsFeed();
                buddyList =  (List<BuddyList>)Session["buddyList"];
                foreach(BuddyList user in buddyList)
                {
                    string EmailAddress = user.Email;
                
                Email objEmail = new Email();
                String strTO = EmailAddress;
                String strFROM = "Fondue@temple.edu";
                String strSubject = Username + " has an updated feed.";
                String strMessage = "Check out what " + Username + " posted on his news feed!";

                try
                {
                    objEmail.SendMail(strTO, strFROM, strSubject, strMessage);
                    
                }
                catch (Exception ex)
                {
                   Response.Write("<script>alert('The email wasn't sent because one of the required fields was missing.');</script>");
                }
                }
                Response.Write("<script>alert('The email was sent.');</script>");
            }
            else { Response.Write("<script>alert('News Feed can not be empty');</script>"); }
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            DataSet newData = (DataSet)Session["newsfeed"];
            LinkButton tempBtn = (LinkButton)sender;
            String UrlLink = tempBtn.Text;

            List<NewsFeed> newsFeed;
            newsFeed = newLogic.ReturnNewsFeed(newData);

            string Url = newLogic.ReturnVideoLink(UrlLink, newsFeed);
            if (Url != "-1")
            {
                Response.Write("<script>window.open( '" + Url + "' , '-blank' );</script>");
            }


        }



        protected void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            gvMesseger.Visible = false;

            if (HFfield.Value == "true")
            {
                txtAdvancedSearch.Visible = false;
                IBadvanced.Visible = false;
                HFfield.Value = "false";
            }

            else
            {
                txtAdvancedSearch.Visible = true;
                IBadvanced.Visible = true;
                HFfield.Value = "true";
            }
        }

        protected void IBSeeNewsFeed_Click(object sender, ImageClickEventArgs e)
        {
            createNewsFeed();
            gvMesseger.Visible = false;
        }

        protected void gvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = gvSearch.SelectedRow.Cells[2].Text;
            string status = "Awating response";
            int id = (int)Session["ID"];
            string myUsername = (string)Session["Username"];
            newDb.SetFriendrequest(username, myUsername, id, status);
            Response.Write("<script>alert('Request was sent');</script>");

        }

        public void loadrequestGV()
        {
            gvFriendRequest.Visible = true;
            btnSubmitNewsFeed.Visible = false;
            txtInput.Visible = false;
            txtVideoUrl.Visible = false;
            gvNewsFeed.Visible = false;
            gvSearch.Visible = false;
            gvAdvancedSearch.Visible = true;
            string myUsername = (string)Session["Username"];
            gvFriendRequest.DataSource = newDb.GetFriendRequest(myUsername);
            gvFriendRequest.DataBind();
        }

        protected void btnRequests_Click(object sender, EventArgs e)
        {
            loadrequestGV();
        }

        protected void gvFriendRequst_RowCommand(Object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            List<UserInfomation> newList;
            newList = (List<UserInfomation>)Session["UserList"];
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            int ID = Convert.ToInt32(gvFriendRequest.DataKeys[rowIndex].Values[0].ToString());

            string userName = gvFriendRequest.DataKeys[rowIndex].Values[1].ToString();
            int friendID = newLogic.GettingUserId(userName, newList);
            int id = (int)Session["ID"];
            string Email = newLogic.GettingUserEmail(userName, newList);

            if (e.CommandName == "Accept")
            {
                newDb.FriendUpdateRequest(ID, "Accept");
                Response.Write("<script>alert('Request was Accepted');</script>");
                newDb.InsertBuddy(id, friendID, userName, Email);
                newDb.InsertBuddy(friendID, id, userName, Email);

            }
            else if (e.CommandName == "Reject")
            {
                newDb.FriendUpdateRequest(ID, "Reject");
                Response.Write("<script>alert('Request was Rejected');</script>");
            }
        }

        public void LoadBuddylist()
        {
            List<BuddyList> buddyList = new List<BuddyList>();
            int id = (int)Session["ID"];
            DataSet newSet = new DataSet();
            newSet= newDb.GetBuddyList(id);
            buddyList = newLogic.CreatingObjectBuddysFromDatabase(newSet);
            Session["buddyList"] = buddyList;
            string emails = newLogic.getemails(buddyList);
            Session["emails"] = emails;
            gvBuddyList.DataSource = newSet;
            gvBuddyList.DataBind();

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
             if (HF.Value == "true")
             {
                 int Myid = (int)Session["ID"];
                 int UserReceivedID = (int)Session["buddyId"];
                 HF.Value = "true";
                 txtMessage.Visible = true;
                 btnSendMessage.Visible = true;
                 txtMessage.Focus();
                 btnSendMessage.Focus();
                 gvMesseger.DataSource = newDb.GetMessegers(Myid, UserReceivedID);
                 gvMesseger.DataBind();
             }
             else {
                 LoadBuddylist();
             }
            
        }

        protected void gvBuddyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<UserInfomation> newList;
            newList = (List<UserInfomation>)Session["UserList"];
            string userName = gvBuddyList.SelectedRow.Cells[2].Text;
            string myUsername = (string)Session["Username"];
            int Myid = (int)Session["ID"];
            int userID = newLogic.GettingUserId(userName, newList);
            Session["buddyId"] = userID;
            Session["BuddyUsername"] = userName;
            LoadMesseger(Myid, userID);
            gvBuddyList.Visible = false;
        }

       
        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            gvBuddyList.Visible = true;
            txtMessage.Visible = true;
            btnSendMessage.Visible = true;
            string myUsername = (string)Session["Username"];
            int Myid = (int)Session["ID"];
            int buddyId = (int)Session["buddyId"];
            string buddyUserName = (string)Session["BuddyUsername"];
            DateTime sendMessage = DateTime.Now;
            string Message = myUsername + ": " + txtMessage.Text;
            string MessageReseived = " ";
            newDb.InsertMessage(Message, MessageReseived, Myid, buddyId, sendMessage);
      
        }

        public void LoadMesseger(int UserSendID, int UserReceivedID)
        {
            txtMessage.Visible = true;
            btnSendMessage.Visible = true;
            gvMesseger.Visible = true;
            HF.Value = "true";
            gvMesseger.DataSource = newDb.GetMessegers(UserSendID, UserReceivedID);
            gvMesseger.DataBind();          
        }

        

    }
}