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
        public static bool CreateAccount(Account account)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Account values(@_userID, @_password) ", conn);
                cmd.Parameters.AddWithValue("@_userID", account._userID);
                cmd.Parameters.AddWithValue("@_password", account._password);

                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool UpdateAccount(Account account)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update Account set password = @_password where userID = @_userID ", conn);
                cmd.Parameters.AddWithValue("@_userID", account._userID);
                cmd.Parameters.AddWithValue("@_password", account._password);

                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeleteAccount(string userID)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"delete from Account where userID = '{userID}'", conn);

                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static Account GetAccount(string userID)
        {
            Account account = null;
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select * from Account where userID = '{userID}'", conn);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    account = new Account(rd.GetString(0), rd.GetString(1));
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return account;
        }
    }
}
