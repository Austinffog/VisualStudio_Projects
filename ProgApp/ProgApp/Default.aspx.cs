using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_BigPillow_Click(object sender, EventArgs e)
        {
            Response.Redirect("BigPillows.aspx");
        }

        protected void btn_SmlPillow_Click(object sender, EventArgs e)
        {
            Response.Redirect("SmallPillows.aspx");
        }
    }
}