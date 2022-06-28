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
        public static string GetEmployeeName(string ID)
        {
            return EmployeeDAL.GetStaffName(ID);
        }
    }
}
