using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPLibrary;
using System.Data;
using System.Drawing;


namespace TermProject
{
    public partial class frmRestorePassword : System.Web.UI.Page
    {
        TPLibrary.DatabaseClass newDb = new TPLibrary.DatabaseClass();
        TPLibrary.Logic newLogic = new TPLibrary.Logic();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownsLists();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string question1, answer1, question2, answer2, question3, answer3;
            List<UserInfomation> newList;
            newList = (List<UserInfomation>)Session["UserList"];

            question1 = ddlQuestion1.Text;
            if (txtAnswer1.Text == "")
            {
                imgCheck.ImageUrl = "pics/redX.png";
            }
            else
            {
                answer1 = txtAnswer1.Text;
                question2 = ddlQuestion2.Text;
                if (txtAnswer2.Text == "")
                {
                    imgCheck1.ImageUrl = "pics/redX.png";
                }
                else
                {
                    answer2 = txtAnswer2.Text;
                    question3 = ddlQuestion3.Text;
                    if (txtAnswer3.Text == "")
                    {
                        imgCheck2.ImageUrl = "pics/redX.png";
                    }
                    else
                    {
                        answer3 = txtAnswer3.Text;
                        lblRetriveInfo.ForeColor = Color.Red;
                        lblRetriveInfo.Text = newLogic.RestorUsernamePassword(question1, answer1, question2, answer2, question3, answer3, newList);
                    }
                }

            }
            
             
        }

        public void BindDropDownsLists()
        {
            DataSet set;
            set = newDb.ReturnSecurityQuestion();
            ddlQuestion1.DataSource = set;
            ddlQuestion1.DataTextField = "Questions";
            ddlQuestion1.DataValueField = "Questions";
            ddlQuestion1.DataBind();
            ddlQuestion2.DataSource = set;
            ddlQuestion2.DataTextField = "Questions";
            ddlQuestion2.DataValueField = "Questions";
            ddlQuestion2.DataBind();
            ddlQuestion3.DataSource = set;
            ddlQuestion3.DataTextField = "Questions";
            ddlQuestion2.DataValueField = "Questions";
            ddlQuestion3.DataBind();
        }

        protected void txtAnswer1_FocusChanged(object sender, EventArgs e)
        {
            if (txtAnswer1.Text != "")
            {
                txtAnswer1.BorderColor = Color.LimeGreen;
                imgCheck.ImageUrl = "pics/GreenCheck.png";
            }

        }

        protected void txtAnswer2_FocusChanged(object sender, EventArgs e)
        {
            if (txtAnswer2.Text != "")
            {
                txtAnswer2.BorderColor = Color.LimeGreen;
                imgCheck1.ImageUrl = "pics/GreenCheck.png";
            }

        }

        protected void txtAnswer3_FocusChanged(object sender, EventArgs e)
        {
            if (txtAnswer3.Text != "")
            {
                txtAnswer3.BorderColor = Color.LimeGreen;
                imgCheck2.ImageUrl = "pics/GreenCheck.png";
            }

        }


    }
}