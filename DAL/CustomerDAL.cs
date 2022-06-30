using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DAL
{
    internal class CustomerDAL
    {
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Customer customer = new Customer
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3),
                        rd.GetString(4),
                        rd.GetString(5),
                        rd.GetString(6)
                    );
                    customers.Add(customer);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customers;
        }
        public static List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Getmember";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Member member = new Member
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3),
                        rd.GetString(4),
                        rd.GetString(5),
                        rd.GetString(6),
                        rd.GetString(7),
                        rd.GetDateTime(8),
                        rd.GetDateTime(9),
                        rd.GetString(10)

                    );
                    members.Add(member);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return members;
        }
        public static List<Member> SearchMember(string str)
        {
            List<Member> members = new List<Member>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchMember";
                cmd.Parameters.AddWithValue("@str", str);
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Member member = new Member
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3),
                        rd.GetString(4),
                        rd.GetString(5),
                        rd.GetString(6),
                        rd.GetString(7),
                        rd.GetDateTime(8),
                        rd.GetDateTime(9),
                        rd.GetString(10)

                    );
                    members.Add(member);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return members;
        }
        public static List<Customer> SearchCustomer(string str)
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer where CustomerID   = '" + str + "' " +
                    "OR fullname = N'" + str + "' OR idNumber = '" + str + "' " +
                    "OR fullName LIKE N'%" + str + "%'";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Customer customer = new Customer
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3),
                        rd.GetString(4),
                        rd.GetString(5),
                        rd.GetString(6)
                    );
                    customers.Add(customer);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customers;
        }
        public static bool InsertCustomer(Customer customer)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "Insert into Customer(customerID,fullName,gender,birthday,phoneNumber,idNumber,address)" +
                    "values (N'" + customer._customerID + "',N'" + customer._fullName + "',N'" + customer._gender + "','" +
                    customer._birthday.ToString("yyyyMMdd") + "','" + customer._phoneNumber + "','" + customer._idNumber + "',N'" +
                    customer._address + "')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }
        public static bool UpdateCustomer(Customer customer)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update Customer set  fullName = N'" + customer._fullName + "', gender = N'" + customer._gender + "'," + "birthday = '" +
                    customer._birthday.ToString("yyyyMMdd") + "', phoneNumber = '" + customer._phoneNumber + "', idNumber = '" + customer._idNumber + "'," +
                    " address = N'" + customer._address + "' " +
                    "where CustomerID = '" + customer._customerID + "'";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeleteCustomer(string ID)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "delete from Customer where customerID = '" + ID + "'";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static string GetCustomerName(string customerID)
        {
            string customerName = "";
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select fullName from Customer where customerID = '{customerID}'", conn);

                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    customerName = data.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerName;
        }
    }
}
