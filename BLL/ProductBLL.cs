using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class ProductBLL
    {
        public static List<Product> GetAllProducts()
        {
            return ProductDAL.GetAllProducts();
        }
        public static string GetProductName(string productID)
        {
            return ProductDAL.GetProductName(productID);
        }
        public static List<Product> SearchProduct(string str)
        {
            return ProductDAL.SearchProduct(str);
        }
    }
}
