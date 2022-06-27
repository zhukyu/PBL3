using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class CourseReceiptBLL
    {
        public static List<CourseReceipt> GetAllCourseReceipts()
        {
            return CourseReceiptDAL.GetAllCourseReceipts();
        }
        public static bool InsertCourseReceipt(CourseReceipt courseReceipt)
        {
            return CourseReceiptDAL.InsertCourseReceipt(courseReceipt);
        }
        public static string GenerateID()
        {
            int count = 1;
            StringBuilder ID = new StringBuilder("CR0000");
            string lastID = CourseReceiptDAL.GetLastID();
            if(lastID != null)
                count = Convert.ToInt32(lastID.Substring(2)); //lấy số thứ tự
            count++;
            string countStr = count.ToString();
            ID.Remove(ID.Length - countStr.Length, countStr.Length); // CR000 - 12 = CR0
            ID.Append(countStr);
            
            return ID.ToString();
        }
    }
}
