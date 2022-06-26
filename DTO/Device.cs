using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Device
    {
        internal string _deviceID { get; set; }
        internal string _deviceName { get; set; }
        internal int _amount { get; set; }
        internal string _status { get; set; }
        internal DateTime _importDate { get; set; }
        internal string? _image { get; set; }
        internal string _employeeID { get; set; }

        public Device()
        {

        }
        public Device(string deviceID, string deviceName, int amount, string status, DateTime importDate, string? image, string employeeID)
        {
            _deviceID = deviceID;
            _deviceName = deviceName;
            _amount = amount;
            _status = status;
            _importDate = importDate;
            _image = image;
            _employeeID = employeeID;
        }
    }
}
