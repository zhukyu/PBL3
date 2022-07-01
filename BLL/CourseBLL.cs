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
        public static Course GetCourse(string ID)
        {
            return CourseDAL.GetCourse(ID);
        }
        public static string GenerateID()
        {
            int count = 1;
            StringBuilder ID = new StringBuilder("CO0000");
            string lastID = CourseDAL.GetLastID();
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
