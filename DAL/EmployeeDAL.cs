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
    internal class EmployeeDAL
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employee";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Employee employee = new Employee
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3),
                        rd.GetString(4),
                        rd.GetString(5),
                        rd.GetString(6),
                        rd.GetString(7),
                        rd.GetString(8)
                    );
                    employees.Add(employee);
                }
                rd.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return employees;
        }
        public static List<Employee> SearchEmployee(string str)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from Employee where EmployeeID   = '" + str + "' " +
                    "OR fullname = N'" + str + "' OR idNumber = '" + str + "' " +
                    "OR fullName LIKE N'%" + str + "%'";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Employee employee = new Employee
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetDateTime(3),
                        rd.GetString(4),
                        rd.GetString(5),
                        rd.GetString(6),
                        rd.GetString(7),
                        rd.GetString(8)
                    );
                    employees.Add(employee);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employees;
        }
        public static bool InsertEmployee(Employee employee)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "Insert into Employee(employeeID,fullName,gender,birthday,phoneNumber,idNumber,address, role, image)" + 
                    "values (N'" + employee._employeeID + "',N'" + employee._fullName + "',N'" + employee._gender + "','" + 
                    employee._birthday.ToString("yyyyMMdd") + "','" + employee._phoneNumber + "','" + employee._idNumber + "',N'" + 
                    employee._address + "',N'" + employee._role + "',N'" + employee._image + "')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if(ret == 1)
                    result = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
            
        }
        public static bool UpdateEmployee(Employee employee)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update Employee set  fullName = N'" + employee._fullName + "', gender = N'" + employee._gender + "'," + "birthday = '" + 
                    employee._birthday.ToString("yyyyMMdd") + "', phoneNumber = '" + employee._phoneNumber + "', idNumber = '" + employee._idNumber + "'," +
                    " address = N'" + employee._address + "', role = N'" + employee._role + "', image = N'" + employee._image + "' " + 
                    "where employeeID = '" + employee._employeeID + "'";
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
        public static bool DeleteEmployee(string ID)
        {
                bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "delete from Employee where employeeID = '" + ID + "'";
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
        public static string GetStaffName(string employeeID)
        {
            string staffName = "";
            SqlConnection conn = new SqlConnection(Program.cnstr);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select * from Employee where employeeID = '{employeeID}'", conn);

                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    staffName = data.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return staffName;
        }
    }
}
