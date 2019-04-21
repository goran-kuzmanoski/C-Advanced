using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Classes
{
    public class Vendor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List< Product > Products { get; set; }
        public Vendor(int id,string name,List<Product> products)
        {
            ID = id;
            Name = name;
            Products = products;
        }
    }
}
