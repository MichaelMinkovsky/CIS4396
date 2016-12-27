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
    public partial class frmRegistration : System.Web.UI.Page
    {
        TPLibrary.DatabaseClass newDb = new TPLibrary.DatabaseClass();
        TPLibrary.Logic newLogic = new TPLibrary.Logic();

        protected void Page_Load(object sender, EventArgs e)
        {
            FillTheDropDown();
        }

        public void FillTheDropDown()
        {
            DataSet set;
            set = newDb.ReturnStateNames();
            ddlState.DataSource = set;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateName";
            ddlState.DataBind();

            set.Clear();
            set = newDb.ReturnSecurityQuestion();
            ddlSecureQues1.DataSource = set;
            ddlSecureQues1.DataTextField = "Questions";
            ddlSecureQues1.DataValueField = "Questions";
            ddlSecureQues1.DataBind();

            ddlSecureQues2.DataSource = set;
            ddlSecureQues2.DataTextField = "Questions";
            ddlSecureQues2.DataValueField = "Questions";
            ddlSecureQues2.DataBind();

            ddlSecureQues3.DataSource = set;
            ddlSecureQues3.DataTextField = "Questions";
            ddlSecureQues3.DataValueField = "Questions";
            ddlSecureQues3.DataBind();

        }

        protected void txtAnswer1_FocusChanged(object sender, EventArgs e)
        {
            if (txtFName.Text != "")
            {
                txtFName.BorderColor = Color.LimeGreen;
                imgCheck.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtLName.Text != "")
            {
                txtLName.BorderColor = Color.LimeGreen;
                imgCheck1.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtAddress.Text != "")
            {
                txtAddress.BorderColor = Color.LimeGreen;
                imgCheck2.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtCity.Text != "")
            {
                txtCity.BorderColor = Color.LimeGreen;
                imgCheck3.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtEmail.Text != "")
            {
                txtEmail.BorderColor = Color.LimeGreen;
                imgCheck4.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtAnswer1.Text != "")
            {
                txtAnswer1.BorderColor = Color.LimeGreen;
                imgCheck5.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtAnswer2.Text != "")
            {
                txtAnswer2.BorderColor = Color.LimeGreen;
                imgCheck6.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtAnswer3.Text != "")
            {
                txtAnswer3.BorderColor = Color.LimeGreen;
                imgCheck7.ImageUrl = "pics/GreenCheck.png";
            }

            if (txtUsername.Text != "")
            {
                txtUsername.BorderColor = Color.LimeGreen;
                imgCheck8.ImageUrl = "pics/GreenCheck.png";
            }

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            string Fname, Lname, address, email, city, state, question1, answer1, question2, answer2, question3, answer3, username, password;
            List<UserInfomation> newList;
            newList = (List<UserInfomation>)Session["UserList"];
            if (txtFName.Text == "")
            {
                lblErrorFName.Text = "Can't be left blank";
                txtFName.BorderColor = Color.Red;
                imgCheck.ImageUrl = "pics/redX.png";
            }
            else
            {
                Fname = txtFName.Text;
                if (txtLName.Text == "")
                {
                    lblErrorLName.Text = "Can't be left blank";
                    txtLName.BorderColor = Color.Red;
                    imgCheck1.ImageUrl = "pics/redX.png";
                }
                else
                {
                    Lname = txtLName.Text;
                    if (txtAddress.Text == "")
                    {
                        lblErrorAddress.Text = "Can't be left blank";
                        txtAddress.BorderColor = Color.Red;
                        imgCheck2.ImageUrl = "pics/redX.png";
                    }
                    else
                    {
                        address = txtAddress.Text;
                        if (txtCity.Text == "")
                        {
                            lblErrorCity.Text = "Can't be left blank";
                            txtCity.BorderColor = Color.Red;
                            imgCheck3.ImageUrl = "pics/redX.png";
                        }
                        else
                        {
                            city = txtCity.Text;
                            if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
                            {
                                lblErrorEmail.Text = "Can't be left blank. Provide proper email";
                                txtEmail.BorderColor = Color.Red;
                                imgCheck4.ImageUrl = "pics/redX.png";
                            }

                            else
                            {
                                email = txtEmail.Text;
                                if (txtAnswer1.Text == "")
                                {
                                    lblErrorAnswer1.Text = "Can't be left blank";
                                    txtAnswer1.BorderColor = Color.Red;
                                    imgCheck5.ImageUrl = "pics/redX.png";
                                }

                                else
                                {
                                    state = ddlState.SelectedValue;
                                    question1 = ddlSecureQues1.SelectedValue;
                                    answer1 = txtAnswer1.Text;
                                    if (txtAnswer2.Text == "")
                                    {
                                        lblErrorAnswer2.Text = "Can't be left blank";
                                        txtAnswer2.BorderColor = Color.Red;
                                        imgCheck6.ImageUrl = "pics/redX.png";
                                    }

                                    else
                                    {

                                        question2 = ddlSecureQues2.SelectedValue;
                                        answer2 = txtAnswer2.Text;
                                        if (txtAnswer3.Text == "")
                                        {
                                            lblErrorAnswer3.Text = "Can't be left blank";
                                            txtAnswer3.BorderColor = Color.Red;
                                            imgCheck7.ImageUrl = "pics/redX.png";
                                        }

                                        else
                                        {
                                            answer3 = txtAnswer3.Text;
                                            question3 = ddlSecureQues2.SelectedValue;
                                            Boolean value = newLogic.CheckUsername(txtUsername.Text, newList);
                                            if (txtUsername.Text == "" && value == true)
                                            {
                                                lblErrorUsername.Text = "Can't be left blank and must be unique";
                                                txtUsername.BorderColor = Color.Red;
                                                imgCheck8.ImageUrl = "pics/redX.png";
                                                
                                            }
                                            else 
                                            {
                                                username = txtUsername.Text;
                                                Session["Username"] = username;
                                                if (txtPassword.Text == "")
                                                {
                                                    lblErrorPassword.Text = "Can't be left blank";
                                                    txtPassword.BorderColor = Color.Red;
                                                    imgCheck9.ImageUrl = "pics/redX.png";
                                                }

                                                else 
                                                {
                                                    password = txtPassword.Text;
                                                    newDb.InsertToUserDataTable(Fname, Lname, state, address, city, email, username, password, question1, answer1, question2, answer2, question3, answer3);
                                                    Server.Transfer("frmUserSettings.aspx"); 
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }







                }
            }

           
        }

    }
}