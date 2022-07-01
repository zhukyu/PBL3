using Gym.DTO;
using Gym.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class CustomerBLL
    {

        public static List<Customer> GetAllCustomers()
        {
            return CustomerDAL.GetAllCustomers();
        }
        public static bool AddCustomer(Customer customer)
        {

            return CustomerDAL.InsertCustomer(customer);
        }
        public static bool UpdateCustomer(Customer customer)
        {

            return CustomerDAL.UpdateCustomer(customer);
        }
        public static bool DeleteCustomer(string ID)
        {

            return CustomerDAL.DeleteCustomer(ID);
        }
        public static List<Customer> SearchCustomer(string str)
        {
            return CustomerDAL.SearchCustomer(str);
        }
        public static Customer GetCustomer(string ID)
        {
            return CustomerDAL.GetCustomer(ID);
        }
        public static String GetCustomerName(string ID)
        {
            return CustomerDAL.GetCustomerName(ID);
        }
        public static string GenerateID()
        {
            int count = 1;
            StringBuilder ID = new StringBuilder("CU0000");
            string lastID = ProductReceiptDAL.GetLastID();
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
