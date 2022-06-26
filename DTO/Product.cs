using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DTO
{
    public class Product
    {
        internal string _productID { get; set; }
        internal string _productName { get; set; }
        internal int _amount { get; set; }
        internal int _price { get; set; }
        internal string? _image { get; set; }

        public Product()
        {

        }
        public Product(string productID, string productName, int amount, int price, string? image)
        {
            _productID = productID;
            _productName = productName;
            _amount = amount;
            _price = price;
            _image = image;
        }
    }
}
