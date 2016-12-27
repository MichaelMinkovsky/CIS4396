using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.IO;
using System.Data;
using TPLibrary;


namespace TermProject
{
    public partial class PictureControl : System.Web.UI.UserControl
    {
        frmProfileInfo myinfo = new frmProfileInfo();
        protected void Page_Load(object sender, EventArgs e)
        {

        TPLibrary.Logic newLogic;

        }
     

        [Category("Misc")]
        public String ProductImage
        {
            get { return ImgControl.ImageUrl; }
            set { ImgControl.ImageUrl = value; }
        }

       
        [Category("Method")]
        public void Select_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Hello');</script>");
            myinfo.LoadNewPicture();
        }

        [Category("Method")]
        protected void Delete_Click(object sender, EventArgs e)
        {
            string filePath = HF.Value;
            File.Delete(filePath);
            myinfo.LoadNewPicture();
        }

        [Category("Misc")]
        public String HiddeField
        {
            get{return HF.Value;}
            set{HF.Value = value;}
        }
    }
}