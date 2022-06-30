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
        public static bool AddCourse(Course course)
        {
            return CourseDAL.InsertCourse(course);
        }
        public static bool UpdateCourse(Course course)
        {
            return CourseDAL.UpdateCourse(course);
        }
        public static bool DeleteCourse(string ID)
        {
            return CourseDAL.DeleteCourse(ID);
        }
        public static List<Course> SearchCourse(string str)
        {
            return CourseDAL.SearchCourse(str);
        }

    }
}
