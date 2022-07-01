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
    internal class DeviceDAL
    {
        public static List<Device> GetAllDevices()
        {
            List<Device> devices = new List<Device>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Device where delete_at is NULL";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Device device = new Device
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetInt32(2),
                        rd.GetString(3),
                        rd.GetDateTime(4),
                        rd.GetString(5),
                        rd.GetString(6)
                    );
                    devices.Add(device);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return devices;
        }
        public static List<Device> SearchDevice(string str)
        {
            List<Device> devices = new List<Device>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from Device where (deviceID= '" + str + "' " +
                    "or deviceName like '%" + str + "%' or employeeID ='" + str + "') and delete_at is NULL";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Device device = new Device
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetInt32(2),
                        rd.GetString(3),
                        rd.GetDateTime(4),
                        rd.GetString(5),
                        rd.GetString(6)
                    );
                    devices.Add(device);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return devices;
        }
        public static bool InsertDevice(Device device)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "Insert into Device(deviceID,deviceName,amount,status,importDate,image,employeeID)" + 
                    "values (N'" + device._deviceID + "',N'" + device._deviceName + "','" + device._amount + "',N'" +
                    device._status + "','" + device._importDate.ToString("yyyyMMdd") + "','" + device._image + "',N'" + device._employeeID + "')";
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
        public static bool UpdateDevice(Device device)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update Device set deviceName=N'" + device._deviceID + "',amount=N'" +
                    device._amount + "',status=N'" + device._status + "',importDate='" + device._importDate.ToString("yyyyMMdd") + 
                    "',employeeID=N'" + device._employeeID + "' ,image=N'" + device._image + "'" + "where deviceID = '" + device._deviceID + "'";
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
        public static bool DeleteDevice(string ID)
        {
            bool result = false;
            try
            {
                string delete_at = DateTime.Now.ToString("yyyyMMdd");
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update Device set delete_at = '" + delete_at + "' where deviceID = '" + ID + "'";
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
        public static string GetLastID()
        {
            string lastID = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 deviceID FROM Device ORDER BY deviceID DESC";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lastID = rd.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lastID;
        }
    }
}
