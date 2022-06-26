using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class ProductReceipt
    {
        internal string _receiptID { get; set; }
        internal string _employeeID { get; set; }
        internal DateTime _publishDate { get; set; }
        internal int _total { get; set; }

        public ProductReceipt()
        {

        }
        public ProductReceipt(string receiptID, string employeeID, DateTime publishDate, int total)
        {
            _receiptID = receiptID;
            _employeeID = employeeID;
            _publishDate = publishDate;
            _total = total;
        }
    }
}
