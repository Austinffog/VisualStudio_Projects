using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DomingoADG.Models;

namespace DomingoADG.Respository
{
    public class InvoiceRespository
    {
        private SqlConnection conn;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getConn"].ToString();
            conn = new SqlConnection(constr);
        }

        //view invoice
        public List<InvoiceModel> GetInvoice()
        {
            Connection();
            List<InvoiceModel> InvoiceList = new List<InvoiceModel>();

            SqlCommand GetCommand = new SqlCommand("Invoices", conn);
            GetCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(GetCommand);
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                InvoiceList.Add(
                    new InvoiceModel
                    {
                        job_card_no = Convert.ToInt32(dr["JobCardNo"]),
                        customer_name = Convert.ToString(dr["CustomerName"]),
                        address = Convert.ToString(dr["Address"]),
                        job_type = Convert.ToString(dr["JobType"]),
                        employee_no = Convert.ToInt32(dr["EmployeeNo"]),
                        employee_name = Convert.ToString(dr["EmployeeName"]),
                        material_used = Convert.ToString(dr["MaterialsUsed"]),
                        customer_no = Convert.ToInt32(dr["CustomerNo"]),
                        sub_total = Convert.ToInt32(dr["SubTotal"]),
                        vat = Convert.ToInt32(dr["VAT"]),
                        total = Convert.ToInt32(dr["Total"])
                    }
                    );
            }
            return InvoiceList;
        }

        public bool CreateInvoice(InvoiceModel obj)
        {
            Connection();
            SqlCommand CreateCommand = new SqlCommand("Invoice", conn);
            CreateCommand.CommandType = CommandType.StoredProcedure;
            CreateCommand.Parameters.AddWithValue("@job_card_no", obj.job_card_no);
            CreateCommand.Parameters.AddWithValue("@customer_name", obj.customer_name);
            CreateCommand.Parameters.AddWithValue("@address", obj.address);
            CreateCommand.Parameters.AddWithValue("@job_type", obj.job_type);
            CreateCommand.Parameters.AddWithValue("@employee_no", obj.employee_no);
            CreateCommand.Parameters.AddWithValue("@employee_name", obj.employee_name);
            CreateCommand.Parameters.AddWithValue("@material_used", obj.material_used);
            CreateCommand.Parameters.AddWithValue("@customer_no", obj.customer_no);
            CreateCommand.Parameters.AddWithValue("@sub_total", obj.sub_total);
            CreateCommand.Parameters.AddWithValue("@vat", obj.vat);
            CreateCommand.Parameters.AddWithValue("@total", obj.total);

            conn.Open();
            int i = CreateCommand.ExecuteNonQuery();
            conn.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}