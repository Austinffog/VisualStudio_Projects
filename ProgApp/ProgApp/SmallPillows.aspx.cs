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
    public partial class SmallPillows : Page
    {
        //connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E69HIDP;Initial Catalog=EcommerceDB;User ID=sa;Password=austin");
        Login login = new Login();

        int smlPillowTotal = 0;
        string total = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //load the database table
            if (!IsPostBack)
            {
                LoadRecord();
            }

            lbl_SuccessMessage.Visible = false;
            lbl_errorMessage.Visible = false;

            if (login.Role != null)
            {
                //check if the role of the user is employee and display order amount
                if (login.Role == "Employee")
                {
                    SqlCommand comm = new SqlCommand("select SmlPillowTotal from TB_Totals", con);
                    SqlDataReader dr = comm.ExecuteReader();

                    total = lbl_Total.Text + dr["SmlPillowTotal"].ToString();

                    lbl_Total.Text = total;

                    lbl_Total.Visible = true;
                }
                else
                {
                    lbl_Total.Visible = false;
                }
            }
            else
            {
                lbl_Total.Visible = false;
            }
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            //get the search term from the user and return it in the grid
            SqlCommand comm = new SqlCommand("select * from TB_SmlPillows where ProductName= '" + TextBox1.Text + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void LoadRecord()
        {
            //load the table from the database and display all of the items
            SqlCommand comm = new SqlCommand("select * from TB_SmlPillows", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btn_Purchase_Click(object sender, EventArgs e)
        {
            if (login.Role != null)
            {
                //update the amount of products ordered
                if (login.Role == "Customer")
                {
                    lbl_SuccessMessage.Visible = true;

                    smlPillowTotal++;

                    con.Open();
                    SqlCommand comm = new SqlCommand("update TB_Totals set SmlPillowTotal= '" + smlPillowTotal + "'", con);
                    comm.ExecuteNonQuery();


                    //insert the order into the shopping cart table
                    comm = new SqlCommand("select Username from TB_User", con);
                    SqlDataReader dr = comm.ExecuteReader();
                    comm = new SqlCommand("insert into TB_ShoppingCart('" + tb_ProductName.Text + "','" + tb_ProductColor.Text + "','" + tb_Size.Text + "','" + int.Parse(tb_Quantity.Text) + "','" + dr["Username"].ToString() + "')", con);
                    comm.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    lbl_errorMessage.Visible = true;
                }

            }
            else
            {
                lbl_errorMessage.Visible = true;
            }
        }
    }
}