using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PoePersonalBudget.DataAccess
{
    public class Class1
    {
        SqlConnection conn = new SqlConnection(@"");

        public string Post(int acc)
        {
            try
            {
                conn.Open();
                string query = $"insert into accValues(accV) values(@a)";
                SqlCommand com = new SqlCommand(query, conn);
                com.Parameters.AddWithValue("@", acc);
                com.ExecuteNonQuery();
                conn.Close();

                return $"{acc} value saved";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}