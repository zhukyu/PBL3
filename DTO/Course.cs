using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Course
    {
        internal string _courseID { get; set; }
        internal string _courseName { get; set; }
        internal string _duration { get; set; }
        internal int _price { get; set; }

        public Course()
        {

        }
        public Course(string courseID, string courseName, string duration, int price)
        {
            _courseID = courseID;
            _courseName = courseName;
            _duration = duration;
            _price = price;
        }
    }
}
