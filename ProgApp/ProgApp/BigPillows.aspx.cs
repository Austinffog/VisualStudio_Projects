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
    public partial class BigPillows : Page
    {
        //connect to the database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E69HIDP;Initial Catalog=EcommerceDB;User ID=sa;Password=austin");
        Login login = new Login();

        int bigPillowTotal = 0;
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

            //display the amount of orders if the value of the role is Employee

            if (login.Role == "Employee")
            {
                con.Open();
                SqlCommand comm = new SqlCommand("select BigPillowTotal from TB_Totals", con);
                SqlDataAdapter d = new SqlDataAdapter(comm);
                SqlDataReader dr = comm.ExecuteReader();
                

                total = lbl_Total.Text + dr["BigPillowTotal"].ToString();

                con.Close();

                lbl_Total.Text = total;

                lbl_Total.Visible = true;
            }
            else
            {
                lbl_Total.Visible = false;
            }

        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            //get the search term from the user and return it in the grid
            SqlCommand comm = new SqlCommand("select * from TB_BigPillows where ProductColor= '" + TextBox1.Text + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        void LoadRecord()
        {
            //load the table from the database and display all of the items
            SqlCommand comm = new SqlCommand("select * from TB_BigPillows", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btn_Purchase_Click(object sender, EventArgs e)
        {
            
                //if a customer is making a purchase increase the product count
                if (login.Role == "Customer")
                {
                    lbl_SuccessMessage.Visible = true;

                    bigPillowTotal++;

                con.Open();
                    SqlCommand comm = new SqlCommand("update TB_Totals set BigPillowTotal= '" + bigPillowTotal + "'", con);
                    comm.ExecuteNonQuery();

                    //insert the order into the shopping cart table
                    comm = new SqlCommand("insert into TB_ShoppingCart('" + tb_Name.Text + "','" + tb_Color.Text + "','" + tb_Size.Text + "','" + int.Parse(tb_Quantity.Text) + "','" + Session["username"].ToString() + "')", con);
                    comm.ExecuteNonQuery();
                con.Close();

                }
                else
                {
                    lbl_errorMessage.Visible = true;
                }
 
        }
    }
}