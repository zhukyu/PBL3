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
    internal class CourseReceiptDAL
    {
        public static List<CourseReceipt> GetAllCourseReceipts()
        {
            List<CourseReceipt> courseReceipts = new List<CourseReceipt>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Course";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CourseReceipt courseReceipt = new CourseReceipt
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetString(3),
                        rd.GetString(4),
                        rd.GetDateTime(5),
                        rd.GetDateTime(6),
                        rd.GetInt32(7)
                    );
                    courseReceipts.Add(courseReceipt);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return courseReceipts;
        }
        public static List<CourseReceipt> GetCourseReceiptsByDate(DateTime beginDate, DateTime endDate, string employeeID)
        {
            List<CourseReceipt> courseReceipts = new List<CourseReceipt>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * " +
                    "from CourseReceipt where " +
                    $"registerDate >= '{beginDate.ToString("yyyyMMdd")}' and registerDate <= '{endDate.ToString("yyyyMMdd")}' " +
                    $"and employeeID like '%{employeeID}%'";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string teacherID = null;
                    if (!rd.IsDBNull(3))
                    {
                        teacherID = rd.GetString(3);
                    }
                    CourseReceipt courseReceipt = new CourseReceipt
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        teacherID,
                        rd.GetString(4),
                        rd.GetDateTime(5),
                        rd.GetDateTime(6),
                        rd.GetInt32(7)
                    );
                    courseReceipts.Add(courseReceipt);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return courseReceipts;
        }
        public static bool InsertCourseReceipt(CourseReceipt courseReceipts)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string teacherID = "NULL";
                if(courseReceipts._teacherID != null)
                {
                    teacherID = $"'{courseReceipts._teacherID}'";
                }
                string st = "insert into CourseReceipt (receiptID ,customerID, courseID, teacherID, employeeID, registerDate, expiredDate, price) " +
                        $"values ('{courseReceipts._receiptID}', '{courseReceipts._customerID}', '{courseReceipts._courseID}', {teacherID}," +
                        $"'{courseReceipts._employeeID}', '{courseReceipts._registerDate.ToString("yyyyMMdd")}', '{courseReceipts._expiredDate.ToString("yyyyMMdd")}', {courseReceipts._price})";
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
        public static CourseReceipt SearchCourseReceipt(string ID)
        {
            CourseReceipt courseRcpt = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from CourseReceipt where receiptID = '{ID}'";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    courseRcpt = new CourseReceipt
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetString(3),
                        rd.GetString(4),
                        rd.GetDateTime(5),
                        rd.GetDateTime(6),
                        rd.GetInt32(7)
                    );
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return courseRcpt;
        }
        public static string GetLastID()
        {
            string lastID = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 receiptID FROM CourseReceipt ORDER BY receiptID DESC";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd.Read())
                {
                    lastID = rd.GetString(0);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lastID;
        }
    }
}
