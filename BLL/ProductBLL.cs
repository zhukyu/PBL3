using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.DAL;
using Gym.DTO;

namespace Gym.BLL
{
    internal class ProductBLL
    {
        public static List<Product> GetAllProducts()
        {
            return ProductDAL.GetAllProducts();
        }
        public static bool AddProduct(Product product)
        {
            product._image = ImageHandle.SaveImage(product._image, product._productID);
            return ProductDAL.InsertProduct(product);
        }
        public static bool UpdateProduct(Product product)
        {
            product._image = ImageHandle.SaveImage(product._image, product._productID);
            return ProductDAL.UpdateProduct(product);
        }
        public static bool DeleteProduct(string ID)
        {
            ImageHandle.DeleteImage("Images\\" + ID + ".jpg");
            return ProductDAL.DeleteProduct(ID);
        }
        public static List<Product> SearchProduct(string str)
        {
            return ProductDAL.SearchProduct(str);
        }
    }
}
