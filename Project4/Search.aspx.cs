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
    public partial class Search : System.Web.UI.Page
    {
        myReference.RealtyWS proxy = new myReference.RealtyWS();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblAppointment.Visible = false;
            lblName.Visible = false;
            txtName.Visible = false;
            lblDate.Visible = false;
            txtDate.Visible = false;
            lblTime.Visible = false;
            txtTime.Visible = false;
            btnSubmit.Visible = false;
            lblAppointments.Visible = false;
        }

        protected void btnSearch1_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string state = txtState.Text;
            float budget;
            if (city != "" && state != "")
            {
                if (float.TryParse(txtBudget.Text, out budget))
                {
                    int id = (int)Session["id"];
                    gvHouses.DataSource = proxy.findHomeByCityStateBudget(city, state, budget, id);
                    gvHouses.DataBind();

                }
                else
                {
                    lblErrorDisplay.Text = "Invalid input for budget. Try again.";
                }
            }
            else
            {
                lblErrorDisplay.Text = "Invalid entry for city or state. Try again.";
            }
        }


        protected void btnSearch2_Click(object sender, EventArgs e)
        {
            float budget;
            int size;
            string homeType;
            if (int.TryParse(txtSize.Text, out size))
            {
                homeType = ddlHomeType.Text;
                if (float.TryParse(txtBudget2.Text, out budget))
                {
                    int id = (int)Session["id"];
                    gvHouses.DataSource = proxy.findHomeByBudgetSizeType(budget, size, homeType, id);
                    gvHouses.DataBind();


                }
                else
                {
                    lblErrorDisplay.Text = "Invalid input for budget. Try again.";
                }
            }
            else { lblErrorDisplay.Text = "Invalid input for size. Try again."; }
        }

        protected void gvHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Houseid = Convert.ToInt32(gvHouses.SelectedRow.Cells[0].Text);
            Session["appointmentId"] = Houseid;
            lblAppointment.Visible = true;
            lblName.Visible = true;
            txtName.Visible = true;
            lblDate.Visible = true;
            txtDate.Visible = true;
            lblTime.Visible = true;
            txtTime.Visible = true;
            btnSubmit.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAppointments.Visible = true;
            int id = (int)Session["id"];
            int HouseId = (int)Session["appointmentId"];
            string name = txtName.Text;
            DateTime date;
            DateTime time;

            if (name != "")
            {
                if (DateTime.TryParse(txtDate.Text, out date))
                {

                    if (DateTime.TryParse(txtTime.Text, out time))
                    {

                        proxy.addRequest(name, date, time, HouseId, id);
                        gvAppointments.DataSource = proxy.displayAppointments(id);
                        gvAppointments.DataBind();


                    }
                    else
                    {
                        lblErrorDisplay.Text = "Invalid input for time. Try again using HH:MM:SS format.";
                    }
                }
                else
                {
                    lblErrorDisplay.Text = "Invalid input for date. Try again using MM/DD/YYYY format.";
                }
            }
            else
            {
                lblErrorDisplay.Text = "Invalid input for name. Try again.";
            }
        }


    }
    
}