using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Shop.Classes
{
    public class Module
    {
        public string Name { get; set; }
        public Dictionary<Part, int> Parts { get; set; }
        private int Discount { get; set; }
        public Module(string name)
        {
            this.Name = name;
            this.Parts = new Dictionary<Part, int>();
        }

        public void AddPartToModule(Part p1, int quantity)
        {
            Parts.Add(p1, quantity);
        }
        public void SetDiscount(int discount)
        {
            this.Discount = discount;
        }
        public double GetPrice()
        {
            double result = 0;
            foreach (var p in Parts)
            {
                result += p.Key.Price * p.Value;
            }
            return result;
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice()-(GetPrice() * Discount / 100);
        }
    }
}
