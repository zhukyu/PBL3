using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Customer
    {
        internal string _customerID { get; set; }
        internal string _fullName { get; set; }
        internal string _gender { get; set; }
        internal DateTime _birthday { get; set; }
        internal string _phoneNumber { get; set; }
        internal string _idNumber { get; set; }
        internal string _address { get; set; }

        public Customer()
        {

        }
        public Customer(string customerID, string fullName, string gender, DateTime birthday, string phoneNumber, string idNumber, string address)
        {
            _customerID = customerID;
            _fullName = fullName;
            _gender = gender;
            _birthday = birthday;
            _phoneNumber = phoneNumber;
            _idNumber = idNumber;
            _address = address;
        }
    }
}
