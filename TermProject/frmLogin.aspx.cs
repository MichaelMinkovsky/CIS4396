using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Web.Security;

namespace TermProject
{
    public partial class frmLogin : System.Web.UI.Page
    {
        TPLibrary.DatabaseClass newDb = new TPLibrary.DatabaseClass();
        TPLibrary.Logic newLogic = new TPLibrary.Logic();
        DataSet newSet = new DataSet();
        string username, loginStatus;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            ListSeesion();
            
            if (!IsPostBack && Request.Cookies["Fondue"] != null)
            {
                HttpCookie cookie = Request.Cookies["Fondue"];
                username = cookie.Values["Name"].ToString();
                loginStatus = cookie.Values["LoginPreference"].ToString();
                if (loginStatus == "Auto") { Server.Transfer("frmHomePage.aspx"); }
                else if(loginStatus =="Fast") {txtUserName.Text = username;}
                WriteCookie();
                
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<UserInfomation> newList;
            newList = (List<UserInfomation>)Session["UserList"];
            string pass = txtPassword.Text;
            string userName = txtUserName.Text;
            Session["Username"] = userName;
            Session["Password"] = pass;
            Boolean value = newLogic.checkLogin(txtUserName.Text, pass, newList);
            if (value == true)
            {
                WriteCookie();
                int id = newLogic.GettingUserId(txtUserName.Text, newList);
                Session["ID"] = id;
                string status = "ONLINE";
                newDb.UpdateUserStatus(userName, status);
                Server.Transfer("frmHomePage.aspx");
                
              
            }

            else {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "The username or password you entered is incorrect." + Environment.NewLine + "Please try again.";
               }
        }

        protected void LinkForgatPassword_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmRestorePassword.aspx");
        }

        public void ListSeesion()
        {
            DataSet newSet;
            newSet = newDb.ReturnUsers();
            List<UserInfomation> newList;
            newList = newLogic.CreatingObjectUsersFromDatabase(newSet);
            Session["UserList"] = newList;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            List<UserInfomation> newList;
            newList = (List<UserInfomation>)Session["UserList"];
            Server.Transfer("frmRegistration.aspx");
        }

        public void WriteCookie()
        {
            string userName = (string)Session["Username"];
            HttpCookie myCookie = new HttpCookie("Login");
            myCookie.Values["Name"] = userName;
            myCookie.Expires = new DateTime(2025, 1, 1);
            Response.Cookies.Add(myCookie);
        }
    }
}