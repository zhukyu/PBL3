﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Employee
    {
        internal string _employeeID { get; set; }
        internal string _fullName { get; set; }
        internal string _gender { get; set; }
        internal DateTime _birthday { get; set; }
        internal string _phoneNumber { get; set; }
        internal string _idNumber { get; set; }
        internal string _address { get; set; }
        internal string _role { get; set; }
        internal string? _image { get; set; }

        public Employee()
        {

        }
        public Employee(string employeeID, string fullName, string gender, DateTime birthday, 
            string phoneNumber, string idNumber, string address, string role, string image)
        {
            _employeeID = employeeID;
            _fullName = fullName;
            _gender = gender;
            _birthday = birthday;
            _phoneNumber = phoneNumber;
            _idNumber = idNumber;
            _address = address;
            _role = role;
            _image = image;
        }
    }
}
