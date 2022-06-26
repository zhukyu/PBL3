using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DAL
{
    internal class AccountDAL
    {
        public static bool Login(Account account)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from Account where userID = @_userID and password = @_password ", conn);
                cmd.Parameters.AddWithValue("@_userID", account._userID);
                cmd.Parameters.AddWithValue("@_password", account._password);

                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    result = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
