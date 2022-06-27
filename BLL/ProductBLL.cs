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
    }
}
