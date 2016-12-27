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
    public partial class picturesControl : System.Web.UI.UserControl
    {
        frmProfileInfo newForm = new frmProfileInfo();
        TPLibrary.Logic newLogic;
        TPLibrary.PictureAddress newPictures;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [Category("Misc")]
        public String ProductImage
        {
            get { return imgDisplay.ImageUrl; }
            set { imgDisplay.ImageUrl = value; }
        }

        [Category("Method")]
        public void imgDisplay_Click(object sender, ImageClickEventArgs e)
        {
            List<PictureAddress> filenames = new List<PictureAddress>();
            filenames = (List<PictureAddress>)Session["fileNames"];
            foreach (PictureAddress item in filenames)
            {
                string fileName = item.Filename;
                if (imgDisplay.ImageUrl == "/Storage/" + item.Filename)
                    newForm.ImgPic.ImageUrl = "Storage/" + fileName;
            }
        }
    }
}