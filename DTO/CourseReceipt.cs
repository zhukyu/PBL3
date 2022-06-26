using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class CourseReceipt
    {
        internal string _receiptID { get; set; }
        internal string _customerID { get; set; }
        internal string _courseID { get; set; }
        internal string _teacherID { get; set; }
        internal string _employeeID { get; set; }
        internal DateTime _registerDate { get; set; }
        internal DateTime _expiredDate { get; set; }
        internal int _price { get; set; }

        public CourseReceipt()
        {

        }
        public CourseReceipt(string receiptID, string customerID, string courseID, string teacherID, string employeeID, DateTime registerDate, DateTime expiredDate, int price)
        {
            _receiptID = receiptID;
            _customerID = customerID;
            _courseID = courseID;
            _teacherID = teacherID;
            _employeeID = employeeID;
            _registerDate = registerDate;
            _expiredDate = expiredDate;
            _price = price;
        }
    }
}
