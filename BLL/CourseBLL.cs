using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class CourseBLL
    {
        public static List<Course> GetAllCourses()
        {
            return CourseDAL.GetAllCourses();
        }
    }
}
