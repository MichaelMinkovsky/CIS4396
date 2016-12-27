using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Drawing;
using TPLibrary;

namespace TermProject
{
    public partial class frmProfileInfo : System.Web.UI.Page
    {
        
        Logic newLogic = new Logic();
        DatabaseClass newDb = new DatabaseClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Login"] == null)
            {
                Response.Redirect("frmLogin.aspx");
            }
             string userName = (string)Session["Username"];
             string folder = Server.MapPath("~/Storage/" + userName + "/");
             if (Directory.Exists(folder))
             { if (!IsPostBack) { LoadNewPicture(); } }

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            int UserId = (int)Session["ID"];
            string userName =(string)Session["Username"];
            if (fileUpload.HasFile)
            {
                string strFileName;
                strFileName = fileUpload.FileName;
                Session["strFileName"] = strFileName;
                string folder = Server.MapPath("~/Storage/" + userName + "/");


                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    fileUpload.SaveAs(Server.MapPath("~/Storage/" + userName + "/" + strFileName));
                    Response.Write("<script>alert('Upload Success');</script>");
                    string fullPath = "~/Storage/" + userName + "/" + strFileName;
                    string uploadedPicture = "~/Storage/" + userName + "/" + strFileName;
                    ImgPic.ImageUrl = fullPath;
                    newDb.InsertPicture(fullPath, UserId);
                    LoadNewPicture();
                }

                else
                {
                    fileUpload.SaveAs(Server.MapPath("~/Storage/" + userName + "/" + strFileName));
                    Response.Write("<script>alert('Upload Success');</script>");
                    string fullPath = "~/Storage/" + userName + "/" + strFileName;
                    string uploadedPicture = "~/Storage/" + userName + "/" + strFileName;
                    ImgPic.ImageUrl = uploadedPicture;
                    string picture = strFileName;
                    newDb.UpdatePicture(fullPath, UserId);
                    LoadNewPicture();

                    List<BuddyList> buddyList;        
                buddyList =  (List<BuddyList>)Session["buddyList"];
                foreach(BuddyList user in buddyList)
                {
                    string EmailAddress = user.Email;
                
                Email objEmail = new Email();
                String strTO = EmailAddress;
                String strFROM = "Fondue@temple.edu";
                String strSubject = "New picture was uploaded by " + userName ;
                String strMessage = userName + " uploaded a new picture to his page! Check it out.";

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
            }

            else
            {
                Response.Write("<script>alert('Please select your file');</script>");
            }
        }


        public void LoadNewPicture()
        {
            string userName = (string)Session["Username"];
            PictureControl ctrl;
            int count = 0;
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Server.MapPath("~/Storage/" + userName + "/"));
            count = dir.GetFiles().Length;
            var folder = Server.MapPath("~/Storage/" + userName + "/");
            if (count > 0)
            {
                string path = Server.MapPath("~/Storage/" + userName + "/");
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Storage/" + userName + "/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    string fileName = Path.GetFileName(filePath);
                    ctrl = (PictureControl)LoadControl("~/PictureControl.ascx");
                    ctrl.ProductImage = "~/Storage/" + userName + "/" + fileName;
                    ctrl.HiddeField = "~/Storage/" + userName + "/" + fileName;
                    ctrl.DataBind();
                    Form.Controls.Add(ctrl);

                }
               
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string companyName, position, cityName, description;
            int id = (int)Session["ID"];
            companyName = txtBusName.Text;
            position = txtPosition.Text;
            cityName = txtCity.Text;
            description = txtDescription.Text;
            newDb.InsertJob(companyName, position, cityName, description, id);

        }


        protected void btnSchoolSubmit_Click(object sender, EventArgs e)
        {
            DateTime start, end;
            string schoolName, major, Schooldescription;
            int id = (int)Session["ID"];
            schoolName = txtSchoolName.Text;
            major = txtMajor.Text;
            Schooldescription = txtSchoolDescription.Text;

            if (DateTime.TryParse(txtTimeStart.Text, out start))
            {
                if (DateTime.TryParse(txtTimeEnd.Text, out  end))
                {
                    newDb.InsertSchool(schoolName, start, end, Schooldescription, major, id);
                }
                else
                {
                    lblMessage.Text = "The end date format must be MM/DD/YYYY";
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Font.Bold = true;
                }
            }
            else
            {
                lblMessage.Text = "The start date format must be MM/DD/YYYY";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Font.Bold = true;
            }

        }

        protected void btnAboutSubmit_Click(object sender, EventArgs e)
        {
            string about, hobby, quotes;
            about = txtAboutME.Text;
            hobby = txtHobbies.Text;
            quotes = txtFavoriteQuotes.Text;
            int id = (int)Session["ID"];
            newDb.InsertAboutMe(about, quotes, hobby, id);
        }
        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmHomePage.aspx");
        }
    }
}