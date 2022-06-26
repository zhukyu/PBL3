
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class ProductReceipt_Detail
    {
        internal string _receiptID { get; set; }
        internal string _productID { get; set; }
        internal int _amount { get; set; }
        internal int _unitPrice { get; set; }
        internal int _unitTotal { get; set; }

        public ProductReceipt_Detail()
        {

        }
        public ProductReceipt_Detail(string receiptID, string productID, int amount, int unitPrice, int unitTotal)
        {
            _receiptID = receiptID;
            _productID = productID;
            _amount = amount;
            _unitPrice = unitPrice;
            _unitTotal = unitTotal;
        }
    }
}
