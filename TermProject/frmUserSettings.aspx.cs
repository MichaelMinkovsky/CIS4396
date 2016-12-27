using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using TPLibrary;

namespace TermProject
{
    public partial class frmUserSettings : System.Web.UI.Page
    {
        TPLibrary.Logic newLogic = new TPLibrary.Logic();
        TPLibrary.DatabaseClass newDb = new TPLibrary.DatabaseClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Login"] == null)
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void FontChange_OnSelect(object sender, EventArgs e)
        {
            string font = ddlFont.SelectedValue;
            Session["Font"] = font;
            if (font == "Forte")
            {
                bdBody.Attributes.Add("style", "font-family: " + font);
            }
            else if (font == "Courier")
            {
                bdBody.Attributes.Add("style", "font-family: " + font);
            }

            else
            {
                bdBody.Attributes.Add("style", "font-family: " + font);
            }

        }

        protected void BackgroundChange_OnSelect(object sender, EventArgs e)
        {
            string bgColor = ddlBackground.SelectedValue;
            Session["BgColor"] = bgColor;
            if (bgColor == "pink")
            {
                bdBody.Attributes.Add("style", "background:"+bgColor);
            }
            else if (bgColor == "blue")
            {
                bdBody.Attributes.Add("style", "background:" + bgColor);
            }

            else if (bgColor == "black")
            {
                bdBody.Attributes.Add("style", "background:" + bgColor);
            }

            else
            {
                bdBody.Attributes.Add("style", "background:" + bgColor);
            }
        }

        protected void FontColorChange_OnSelect(object sender, EventArgs e)
        {   
            string fontColor = ddlFontColor.SelectedValue;
            Session["FontColor"] = fontColor;
            if (fontColor == "Pink")
            { 
                bdBody.Attributes.Add("style", "Color: " + fontColor);
            }
            else if (fontColor == "Blue")
            {
                bdBody.Attributes.Add("style", "Color: " + fontColor);
            }

            else if (fontColor == "Black")
            {
                bdBody.Attributes.Add("style", "Color: " + fontColor);
            }

            else
            {
                bdBody.Attributes.Add("style", "Color: " + fontColor);
            }
        }


        protected void ThemeChange_OnSelect(object sender, EventArgs e)
        {
            string theme = ddlFullTheme.SelectedValue;
            string themeFontColor, themeBgColor, themeFont;
            if (theme == "Batman")
            {
                 themeFontColor = "White";
                 themeBgColor = "black";
                 themeFont = "Magneto";
                 bdBody.Attributes.Add("style", "Color: " + themeFontColor + ";" + "background:" + themeBgColor + ";" + "font-family: " + themeFont);
            }
            else if (theme == "Blue")
            {
                 themeFontColor = "White";
                 themeBgColor = "blue";
                 themeFont = "Terminal";
                 bdBody.Attributes.Add("style", "Color: " + themeFontColor + ";" + "background:" + themeBgColor + ";" + "font-family: " + themeFont);
            }

            else if (theme == "Girlish")
            {
                themeFontColor = "Cyan";
                themeBgColor = "pink";
                themeFont = "System";
                bdBody.Attributes.Add("style", "Color: " + themeFontColor + ";" + "background:" + themeBgColor + ";" + "font-family: " + themeFont);
            }

            else
            {
                 themeFontColor = "Black";
                 themeBgColor = "white";
                 themeFont = "Courier";
                 bdBody.Attributes.Add("style", "Color: " + themeFontColor + ";" + "background:" + themeBgColor + ";" + "font-family: " + themeFont);
            }

            Session["ThemeFont"] = themeFont;
            Session["ThemeBgColor"] = themeBgColor;
            Session["ThemeFontColor"] = themeFontColor;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

           string font = (string)Session["Font"];
           string bgColor = (string)Session["BgColor"];
           string fontColor = (string)Session["FontColor"];
           bdBody.Attributes.Add("style", "Color: " + fontColor + ";" + "background:" + bgColor + ";" + "font-family: " + font);
           string userName = (string)Session["Username"];
           lblInfo.Text = "That how your homepage look like";

           newDb.InsertUserPreferences(font, fontColor, bgColor, userName);
           
        }

        protected void btnThemeSave_Click(object sender, EventArgs e)
        {
            string userName = (string)Session["Username"];
            string font = (string)Session["ThemeFont"];
            string bgColor =(string)Session["ThemeBgColor"];
            string fontColor = (string)Session["ThemeFontColor"];
            bdBody.Attributes.Add("style", "Color: " + fontColor + ";" + "background:" + bgColor + ";" + "font-family: " + font);
            lblSelectedTheme.Text = "Your theme was saved";
            newDb.InsertUserPreferences(font, fontColor, bgColor, userName);
        }

        protected void btnLoginPreference_Click(object sender, EventArgs e)
        {
            string userName = (string)Session["Username"];
            string LoginPreference = rblLoginPreference.SelectedValue.ToString();
            newDb.InsertUserLoginSetting(LoginPreference, userName);
            lblLoginPreference.Text = "Login Preferences were saved";
            Session["LoginPreference"] = LoginPreference;
            WriteCookie();
        }

        protected void btnGlobalSetting_Click(object sender, EventArgs e)
        {
            string userName = (string)Session["Username"];
            string photoPrivacy = ddlGlobalPrivacySettings.SelectedValue;
            string profileInfoPrivacy  = ddlGlobalPrivacySettings.SelectedValue;
            string contactInfoPrivacy = ddlGlobalPrivacySettings.SelectedValue;
            newDb.InsertUserPrivacySetting(photoPrivacy, profileInfoPrivacy, contactInfoPrivacy, userName);

            if (ddlGlobalPrivacySettings.SelectedValue == "public") { Application["public"] = ddlGlobalPrivacySettings.SelectedValue; }
        }

        protected void btnSavePrivacy_Click(object sender, EventArgs e)
        {
            string userName = (string)Session["Username"];
            string photoPrivacy = ddlGlobalPhotoPrivacy.SelectedValue;
            string profileInfo = ddlProfileInformation.SelectedValue;
            string contactInfo = ddlContactInfo.SelectedValue;
            newDb.InsertUserPrivacySetting(photoPrivacy, profileInfo, contactInfo, userName);
            if(ddlGlobalPhotoPrivacy.SelectedValue == "public")
            { Application["public"] = ddlGlobalPhotoPrivacy.SelectedValue; }

            if (ddlProfileInformation.SelectedValue == "public")
            { Application["public"] = ddlProfileInformation.SelectedValue; }

            if (ddlContactInfo.SelectedValue == "public")
            { Application["public"] = ddlContactInfo.SelectedValue; }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            DataSet newSet;
            newSet = newDb.ReturnUsers();
            List<UserInfomation> newList;
            newList = newLogic.CreatingObjectUsersFromDatabase(newSet);
            Session["UserList"] = newList;
        
            Server.Transfer("frmProfileInfo.aspx");
            
        }

        public void WriteCookie()
        {
            string LoginPreference = (string)Session["LoginPreference"];
            string pass = (string)Session["Username"];
            string userName = (string)Session["Username"];
            HttpCookie myCookie = new HttpCookie("Fondue");
            myCookie.Values["Name"] = userName;
            myCookie.Values["Password"] = pass;
            myCookie.Values["LoginPreference"] = LoginPreference;
            myCookie.Expires = new DateTime(2025, 1, 1);
            Response.Cookies.Add(myCookie);
        }
    }
}