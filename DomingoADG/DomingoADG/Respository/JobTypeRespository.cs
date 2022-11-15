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
    public class JobTypeRespository
    {
        private SqlConnection conn;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getConn"].ToString();
            conn = new SqlConnection(constr);
        }

        //view Job Type
        public List<JobTypeModel> GetJobType()
        {
            Connection();
            List<JobTypeModel> JobTypeList = new List<JobTypeModel>();

            SqlCommand GetCommand = new SqlCommand("JobTypeUpdate", conn);
            GetCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(GetCommand);
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                JobTypeList.Add(
                    new JobTypeModel
                    {
                        job_type = Convert.ToString(dr["JobType"]),
                        daily_rate = Convert.ToInt32(dr["DailyRate"])
                    }
                    );
            }
            return JobTypeList;
        }

        public bool CreateJobType(JobTypeModel obj)
        {
            Connection();
            SqlCommand CreateCommand = new SqlCommand("JobTypeUpdate", conn);
            CreateCommand.CommandType = CommandType.StoredProcedure;
            CreateCommand.Parameters.AddWithValue("@job_type", obj.job_type);
            CreateCommand.Parameters.AddWithValue("@daily_rate", obj.daily_rate);

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

        //update job type daily rate
        public bool UpdateJobType(JobTypeModel obj)
        {
            Connection();
            SqlCommand UpdateCommand = new SqlCommand("JobTypeUpdate", conn);

            UpdateCommand.CommandType = CommandType.StoredProcedure;
            UpdateCommand.Parameters.AddWithValue("@daily_rate", obj.daily_rate);

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