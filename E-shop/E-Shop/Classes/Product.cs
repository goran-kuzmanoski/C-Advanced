using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Classes
{
    public class Product
    {
        public int ProductCode { get; set; }
        public string  Name { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product(int productcode,string name,double weight,int quantity,double price)
        {
            ProductCode = productcode;
            Name = name;
            Weight = weight;
            Quantity = quantity;
            Price = price;
        }
    }
}
