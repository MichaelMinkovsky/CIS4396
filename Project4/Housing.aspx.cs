using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project4
{
    public partial class Housing : System.Web.UI.Page
    {
        myReference.RealtyWS proxy = new myReference.RealtyWS();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblErrorDisplay.Text = "";
            int id;
            if (int.TryParse(txtID.Text, out id))
            {
                Session["id"] = id;
                gvHouses.DataSource = proxy.findMatchingHomes(id);
                gvHouses.DataBind();
            }
            else { lblErrorDisplay.Text = "Invalid input for RealtorID. Try again with 1, 2, 3, 4, 5, or 6."; }
        }

        protected void gvHouses_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            lblErrorDisplay.Text = "";
            int rowIndex = e.RowIndex;
            string ID = gvHouses.DataKeys[rowIndex]["Id"].ToString();
            int id = Convert.ToInt32(ID);
            proxy.deleteHome(id);
            int idn= (int)Session["id"];
            gvHouses.DataSource = proxy.findMatchingHomes(idn);
            gvHouses.DataBind();
            gvHouses.EditIndex = -1;

        }

        protected void gvHouses_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            gvHouses.EditIndex = e.NewEditIndex;
            int id= (int)Session["id"];
            gvHouses.DataSource = proxy.findMatchingHomes(id);
            gvHouses.DataBind(); 

        }

        protected void gvHouses_RowCancelingEdit(Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            gvHouses.EditIndex = -1;
            int id= (int)Session["id"];
            gvHouses.DataSource = proxy.findMatchingHomes(id);
            gvHouses.DataBind(); 
        }

        protected void gvHouses_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TextBox TBox;
            TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[0].Controls[0];
            string id = TBox.Text;
            int ID;
            float lPrice;
            int sqFootage;
            int nBedrooms;
            int nBathrooms;

            lblErrorDisplay.Text = "";
            if (int.TryParse(id, out ID))
            {
                TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[1].Controls[0];
                if (TBox.Text != "")
                {
                    string address = TBox.Text;
                    TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[2].Controls[0];
                    if (TBox.Text != "")
                    {
                        string city = TBox.Text;
                        TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[3].Controls[0];
                        if (TBox.Text != "")
                        {
                            string state = TBox.Text;
                            TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[4].Controls[0];
                            if (float.TryParse(TBox.Text, out lPrice))
                            {
                                TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[5].Controls[0];

                                if (int.TryParse(TBox.Text, out sqFootage))
                                {
                                    TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[6].Controls[0];
                                    if (TBox.Text != "")
                                    {
                                        string availability = TBox.Text;
                                        TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[7].Controls[0];
                                        if (int.TryParse(TBox.Text, out nBedrooms))
                                        {
                                            TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[8].Controls[0];
                                            if (int.TryParse(TBox.Text, out nBathrooms))
                                            {
                                                TBox = (TextBox)gvHouses.Rows[rowIndex].Cells[9].Controls[0];
                                                if (TBox.Text != "")
                                                {
                                                    string houseType = TBox.Text;

                                                    proxy.updateHome(address, city, state, lPrice, sqFootage, availability, nBedrooms, nBathrooms, houseType, ID);
                                                    gvHouses.EditIndex = -1;
                                                    int idn = (int)Session["id"];
                                                    gvHouses.DataSource = proxy.findMatchingHomes(idn);
                                                    gvHouses.DataBind();
                                                }
                                                else { lblErrorDisplay.Text = "Invalid entry for House Type. Try again."; }
                                            }
                                            else { lblErrorDisplay.Text = "Invalid entry for # of Bathrooms. Try again."; }
                                        }
                                        else { lblErrorDisplay.Text = "Invalid entry for # of Bedrooms. Try again."; }
                                    }
                                    else { lblErrorDisplay.Text = "Invalid entry for Availability. Try again."; }
                                }
                                else { lblErrorDisplay.Text = "Invalid entry for Square Footage. Try again."; }
                            }
                            else { lblErrorDisplay.Text = "Invalid entry for Listing Price. Try again."; }
                        }
                        else { lblErrorDisplay.Text = "Invalid entry for State. Try again."; }
                    }
                    else { lblErrorDisplay.Text = "Invalid entry for City. Try again."; }
                }
                else { lblErrorDisplay.Text = "Invalid entry for Address. Try again."; }
            }
            else { lblErrorDisplay.Text = "Invalid entry for ID. Try again."; }

        }

        protected void btnFindYourHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }



    }
}
