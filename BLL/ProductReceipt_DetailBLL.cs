using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.DAL;
using Gym.DTO;

namespace Gym.BLL
{
    internal class ProductReceipt_DetailBLL
    {
        public static List<ProductReceipt_Detail> GetAllProductReceipts(string receiptID)
        {
            return ProductReceipt_DetailDAL.GetAllProductReceiptItems(receiptID);
        }
        public static bool InsertProductReceiptItem(ProductReceipt_Detail item)
        {
            return ProductReceipt_DetailDAL.InsertProductReceiptItem(item);
        }
    }
}
