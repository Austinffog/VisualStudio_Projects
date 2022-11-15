using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgApp
{
    public partial class Login : System.Web.UI.Page
    {

        public string Role;

        protected void Page_Load(object sender, EventArgs e)
        {
            //set error message off
            lbl_ErrorMessage.Visible = false;

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-E69HIDP;Initial Catalog=EcommerceDB;User ID=sa;Password=austin"))
            {
                con.Open();
                string query = "SELECT COUNT(1) FROM TB_User WHERE username=@username AND email=@email AND role=@role AND password=@password";
                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.AddWithValue("@username", tb_Username.Text.Trim());
                comm.Parameters.AddWithValue("@email", tb_Email.Text.Trim());
                comm.Parameters.AddWithValue("@role", tb_Role.Text.Trim());
                comm.Parameters.AddWithValue("@password", tb_Password.Text.Trim());
                int count = Convert.ToInt32(comm.ExecuteScalar());

                if (count == 1)
                {
                    //create a sesssion for the user
                    Session["username"] = tb_Username.Text.Trim();
                    //navigate to the home page on success
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lbl_ErrorMessage.Visible = true;
                }

                comm = new SqlCommand("select Username from TB_User", con);
                SqlDataReader dr = comm.ExecuteReader();
                comm = new SqlCommand("select Role from TB_User where Username='" + dr["Username"] + "'", con);
                SqlDataReader sdr = comm.ExecuteReader();
                Role = sdr["Role"].ToString();
            }

        }

        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            //logout and end user session
            Session.Abandon();
        }

        protected void tb_Role_TextChanged(object sender, EventArgs e)
        {

        }

    }
}