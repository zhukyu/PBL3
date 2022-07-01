using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class DeviceBLL
    {
        public static List<Device> GetAllDevices()
        {
            return DeviceDAL.GetAllDevices();
        }
        public static bool AddDevice(Device device)
        {
            device._image = ImageHandle.SaveImage(device._image, device._deviceID);
            return DeviceDAL.InsertDevice(device);
        }
        public static bool UpdateDevice(Device device)
        {
            device._image = ImageHandle.SaveImage(device._image, device._deviceID);
            return DeviceDAL.UpdateDevice(device);
        }
        public static bool DeleteDevice(string ID)
        {
            ImageHandle.DeleteImage("Images\\" + ID + ".jpg");
            return DeviceDAL.DeleteDevice(ID);
        }
        public static List<Device> SearchDevice(string str)
        {
            return DeviceDAL.SearchDevice(str);
        }
        public static string GenerateID()
        {
            int count = 0;
            StringBuilder ID = new StringBuilder("DV0000");
            string lastID = DeviceDAL.GetLastID();
            if (lastID != null)
                count = Convert.ToInt32(lastID.Substring(2)); //lấy số thứ tự
            count++;
            string countStr = count.ToString();
            ID.Remove(ID.Length - countStr.Length, countStr.Length); // CR000 - 12 = CR0
            ID.Append(countStr); // CR0 + 12 = CR012

            return ID.ToString();
        }
    }
}
