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
    public class EmployeeRespository
    {
        private SqlConnection conn;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getConn"].ToString();
            conn = new SqlConnection(constr);
        }

        //view employees
        public List<EmployeeModel> GetEmployee()
        {
            Connection();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();

            SqlCommand GetCommand = new SqlCommand("RetrieveEmployees", conn);
            GetCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(GetCommand);
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeList.Add(
                    new EmployeeModel
                    {
                        job_card_no = Convert.ToInt32(dr["JobCardNo"]),
                        employee_no = Convert.ToInt32(dr["EmployeeNo"]),
                        employee_name = Convert.ToString(dr["EmployeeName"])

                    }
                    );
            }
            return EmployeeList;
        }

        public bool CreateEmployee(EmployeeModel obj)
        {
            Connection();
            SqlCommand CreateCommand = new SqlCommand("CreateEmployees", conn);
            CreateCommand.CommandType = CommandType.StoredProcedure;
            CreateCommand.Parameters.AddWithValue("@job_card_no", obj.job_card_no);
            CreateCommand.Parameters.AddWithValue("@employee_no", obj.employee_no);
            CreateCommand.Parameters.AddWithValue("@employee_name", obj.employee_name);

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

        //update employees
        public bool UpdateEmployee(EmployeeModel obj)
        {
            Connection();
            SqlCommand UpdateCommand = new SqlCommand("UpdateEmployees", conn);

            UpdateCommand.CommandType = CommandType.StoredProcedure;
            UpdateCommand.Parameters.AddWithValue("@job_card_no", obj.job_card_no);
            UpdateCommand.Parameters.AddWithValue("@employee_no", obj.employee_no);
            UpdateCommand.Parameters.AddWithValue("@employee_name", obj.employee_name);

            conn.Open();
            int i = UpdateCommand.ExecuteNonQuery();
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