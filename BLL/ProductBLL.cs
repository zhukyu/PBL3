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
        public static Product GetProduct(string ID)
        {
            return ProductDAL.GetProduct(ID);
        }
        public static string GetProductName(string ID)
        {
            return ProductDAL.GetProductName(ID);
        }
        public static string GenerateID()
        {
            int count =0;
            StringBuilder ID = new StringBuilder("PD0000");
            string lastID = ProductDAL.GetLastID();
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
