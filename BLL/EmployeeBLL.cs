using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class EmployeeBLL
    {
        public static List<Employee> GetAllEmployees()
        {
            return EmployeeDAL.GetAllEmployees();
        }
        public static List<Employee> GetAllPTs()
        {
            return EmployeeDAL.GetAllPTs();
        }
        public static bool AddEmployee(Employee employee)
        {
            employee._image = ImageHandle.SaveImage(employee._image, employee._employeeID);
            return EmployeeDAL.InsertEmployee(employee);
        }
        public static bool UpdateEmployee(Employee employee)
        {
            employee._image = ImageHandle.SaveImage(employee._image, employee._employeeID);
            return EmployeeDAL.UpdateEmployee(employee);
        }
        public static bool DeleteEmployee(string ID)
        {
            ImageHandle.DeleteImage("Images\\" + ID + ".jpg");
            return EmployeeDAL.DeleteEmployee(ID);
        }
        public static List<Employee> SearchEmployee(string str)
        {
            return EmployeeDAL.SearchEmployee(str);
        }
        public static Employee GetEmployee(string ID)
        {
            return EmployeeDAL.GetEmployee(ID);
        }
        public static string GetEmployeeName(string ID)
        {
            return EmployeeDAL.GetStaffName(ID);
        }
        public static string GenerateID()
        {
            int count = 0;
            StringBuilder ID = new StringBuilder("EM0000");
            string lastID = EmployeeDAL.GetLastID();
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
