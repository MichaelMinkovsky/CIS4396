using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342Solution
{
    public partial class Demo : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            count++;
            lblDisplay.Text = "You clicked the Button " + count + " times.";
        }
    }
}