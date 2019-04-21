using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Classes
{
    public class Vendor
    {
        public string Name { get; set; }
        public List< Product > Products { get; set; }
        public Vendor(string name,List<Product> products)
        {
            Name = name;
            Products = products;
        }
    }
}
