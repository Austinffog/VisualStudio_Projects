using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoePersonalBudget
{
    public partial class Calculations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("CalculatePersonalBudget.aspx");
            }
            catch (Exception)
            {

            }
        }
    }
}