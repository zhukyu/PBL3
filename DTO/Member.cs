using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Member : Customer
    {
        internal string _courseName { get; set; }
        internal DateTime _registerDate { get; set; }
        internal DateTime _expiredDate { get; set; }
        internal string? _teacherID { get; set; }

        public Member()
        {

        }
        public Member(string customerID, string fullName, string gender, DateTime birthday, string phoneNumber, string idNumber, string address, 
            string courseName, DateTime registerDate, DateTime expiredDate, string? teacherID)
            : base(customerID, fullName, gender, birthday, phoneNumber, idNumber, address)
        {
            _courseName = courseName;
            _registerDate = registerDate;
            _expiredDate = expiredDate;
            _teacherID = teacherID;
        }
    }
}
