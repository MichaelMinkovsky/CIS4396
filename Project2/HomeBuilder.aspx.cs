using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using HomeBuilderLibrary;

namespace Project2
{
    public partial class HomeBuilder : System.Web.UI.Page
    {
        DBConnect objDb = new DBConnect();

        Home objHome = new Home();

        public double totalPrice = 0;
        private const int PRICE_COLUMN = 3;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String strSQL = "SELECT * FROM HomeBuilder_t";
                String strSQL1 = "SELECT * FROM LivingRoomUpgrades_t";
                String strSQL2 = "SELECT * FROM BedroomUpgrades_t";
                String strSQL3 = "SELECT * FROM KitchenUpgrades_t";
                String strSQL4 = "SELECT * FROM BathroomUpgrades_t";
                gvRooms.DataSource = objDb.GetDataSet(strSQL);
                gvRooms.DataBind();
                gvLivingRoom.DataSource = objDb.GetDataSet(strSQL1);
                gvLivingRoom.DataBind();
                gvBedroom.DataSource = objDb.GetDataSet(strSQL2);
                gvBedroom.DataBind();
                gvKitchen.DataSource = objDb.GetDataSet(strSQL3);
                gvKitchen.DataBind();
                gvBathroom.DataSource = objDb.GetDataSet(strSQL4);
                gvBathroom.DataBind();
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String address = txtAddress.Text;
            //long phoneNumber = long.Parse(txtNum.Text);

            if (txtName.Text == "")
                lblErrorDisplay.Text = "You must enter a name.";
            else if (txtAddress.Text == "")
                lblErrorDisplay.Text = "Address field cannot be empty.";
            else if (txtNum.Text == "")
                lblErrorDisplay.Text = "Phone number field cannot be empty.";

            String outputMessage = "Thank you, " + name + ". Your selection has been recorded. Here are the options you picked for your home.";
            lblOutputMessage.Text = outputMessage;
            lblOutputName.Text = "Name: " + txtName.Text;
            lblOutputAddress.Text = "Address: " + txtAddress.Text;
            lblOutputPhoneNumber.Text = "Phone Number: " + txtNum.Text;

            for (int i = 0; i < gvRooms.Rows.Count; i++)
            {
                CheckBox cbox;
                cbox = (CheckBox)gvRooms.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked)
                {
                    string description = gvRooms.Rows[i].Cells[1].Text;
                    double price = double.Parse(gvRooms.Rows[i].Cells[2].Text);
                    string len = ((TextBox)gvRooms.Rows[i].FindControl("TextBox1")).Text;
                    int length = int.Parse(len);
                    string wid = ((TextBox)gvRooms.Rows[i].FindControl("TextBox2")).Text;
                    int width = int.Parse(wid);
                    objHome.AddRoom(description, price, length, width);
                }
            }

            for (int i = 0; i < gvLivingRoom.Rows.Count; i++)
            {
                CheckBox cbox;
                cbox = (CheckBox)gvLivingRoom.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked)
                {
                    string description = gvLivingRoom.Rows[i].Cells[1].Text;
                    double price = double.Parse(gvLivingRoom.Rows[i].Cells[2].Text);
                    string upgradeName = gvLivingRoom.Rows[i].Cells[3].Text;
                    objHome.AddUpgrade(description, price, upgradeName);
                }
            }

            for (int i = 0; i < gvBedroom.Rows.Count; i++)
            {
                CheckBox cbox;
                cbox = (CheckBox)gvBedroom.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked)
                {
                    string description = gvBedroom.Rows[i].Cells[1].Text;
                    double price = double.Parse(gvBedroom.Rows[i].Cells[2].Text);
                    string upgradeName = gvBedroom.Rows[i].Cells[3].Text;
                    objHome.AddUpgrade(description, price, upgradeName);
                }
            }

            for (int i = 0; i < gvKitchen.Rows.Count; i++)
            {
                CheckBox cbox;
                cbox = (CheckBox)gvKitchen.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked)
                {
                    string description = gvKitchen.Rows[i].Cells[1].Text;
                    double price = double.Parse(gvKitchen.Rows[i].Cells[2].Text);
                    string upgradeName = gvKitchen.Rows[i].Cells[3].Text;
                    objHome.AddUpgrade(description, price, upgradeName);
                }
            }

            for (int i = 0; i < gvBathroom.Rows.Count; i++)
            {
                CheckBox cbox;
                cbox = (CheckBox)gvBathroom.Rows[i].FindControl("CheckBox1");
                if (cbox.Checked)
                {
                    string description = gvBathroom.Rows[i].Cells[1].Text;
                    double price = double.Parse(gvBathroom.Rows[i].Cells[2].Text);
                    string upgradeName = gvBathroom.Rows[i].Cells[3].Text;
                    objHome.AddUpgrade(description, price, upgradeName);
                }
            }
            btnSubmit.Visible = false;
            lblName.Visible = false;
            lblAddress.Visible = false;
            lblPhoneNumber.Visible = false;
            lblRoomDisplay.Visible = false;
            lblLivingRoomUpgrade.Visible = false;
            lblBedroomUpgrade.Visible = false;
            lblKitchenUpgrade.Visible = false;
            lblBathroomUpgrade.Visible = false;
            gvRooms.Visible = false;
            gvBedroom.Visible = false;
            gvLivingRoom.Visible = false;
            gvKitchen.Visible = false;
            gvBathroom.Visible = false;
            txtName.Visible = false;
            txtAddress.Visible = false;
            txtNum.Visible = false;


            gvOutput.DataSource = objHome.OutputList();
            gvOutput.DataBind();

            for (int i = 0; i < gvOutput.Rows.Count; i++)
                {
                    totalPrice = totalPrice + int.Parse(gvOutput.Rows[i].Cells[PRICE_COLUMN].Text);
                }

            gvOutput.Columns[PRICE_COLUMN].FooterText = totalPrice.ToString("C2"); 
            gvOutput.DataBind();
        }



    }
}