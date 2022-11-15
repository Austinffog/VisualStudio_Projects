using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgApp
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        //connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E69HIDP;Initial Catalog=EcommerceDB;User ID=sa;Password=austin");

        protected void Page_Load(object sender, EventArgs e)
        {
            //load the database table
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        void LoadRecord()
        {
            //load the table from the database and display all of the items
            con.Open();
            SqlCommand comm = new SqlCommand("select Username from TB_User", con);
            SqlDataReader dr = comm.ExecuteReader();
            con.Close();
            comm = new SqlCommand("select * from TB_ShoppingCart where Username='" + dr["username"].ToString() + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}