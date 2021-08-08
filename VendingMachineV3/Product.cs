using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineV3
{
    public class Product
    {
        public Product(string productName, double productPrice, int productQuanity,Image picture)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuanity = productQuanity;
            Image = picture;
        }
        public Image Image { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuanity { get; set; }
    }
}
