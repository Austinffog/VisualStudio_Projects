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
    public class JobCardRespository
    {
        private SqlConnection conn;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getConn"].ToString();
            conn = new SqlConnection(constr);
        }

        //view Job Cards
        public List<JobCardModel> GetJobCards()
        {
            Connection();
            List<JobCardModel> JobCardList = new List<JobCardModel>();

            SqlCommand GetCommand = new SqlCommand("JobCards", conn);
            GetCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(GetCommand);
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                JobCardList.Add(
                    new JobCardModel
                    {
                        job_card_no = Convert.ToInt32(dr["JobCardNo"]),
                        job_type = Convert.ToString(dr["JobType"]),
                        no_of_days = Convert.ToInt32(dr["NoOfDays"]),
                        material_used = Convert.ToString(dr["MaterialsUsed"]),
                        customer_no = Convert.ToInt32(dr["CustomerNo"])
                    }
                    );
            }
            return JobCardList;
        }

        public bool CreateJobCards(JobCardModel obj)
        {
            Connection();
            SqlCommand CreateCommand = new SqlCommand("CreateJobcards", conn);
            CreateCommand.CommandType = CommandType.StoredProcedure;
            CreateCommand.Parameters.AddWithValue("@job_card_no", obj.job_card_no);
            CreateCommand.Parameters.AddWithValue("@job_type", obj.job_type);
            CreateCommand.Parameters.AddWithValue("@no_of_days", obj.no_of_days);
            CreateCommand.Parameters.AddWithValue("@material_used", obj.material_used);
            CreateCommand.Parameters.AddWithValue("@customer_no", obj.customer_no);

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