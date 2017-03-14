using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        string connString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        string command = String.Empty;

        public bool AuthorizeUSer(int userId, string password)
        {
            int count = 0;
            command = "Select count(*) from tbl_user where userid = '"+userId+"' and password = '"+password+"' ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if (count == 0 )
                return true;

            return false;  
        }

        public string GetUserName(int userId)
        {
            command = "Select firstname, lastname from tbl_user where userid = " + userId ;
            string name = string.Empty;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr[0].ToString() + rdr[1].ToString();
                }
            }
            return name;
        }
    }
}
