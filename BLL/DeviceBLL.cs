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
    }
}
