using Gym.DAL;
using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class ProductReceiptBLL
    {
        public static List<ProductReceipt> GetAllProductReceipts()
        {
            return ProductReceiptDAL.GetAllProductReceipts();
        }
        public static List<ProductReceipt> GetProductReceiptsByDate(DateTime beginDate, DateTime endDate)
        {
            return ProductReceiptDAL.GetProductReceiptsByDate(beginDate, endDate);
        }
        public static bool InsertProductReceipt(ProductReceipt ProductReceipt)
        {
            return ProductReceiptDAL.InsertProductReceipt(ProductReceipt);
        }
        public static string GenerateID()
        {
            int count = 0;
            StringBuilder ID = new StringBuilder("PR0000");
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
