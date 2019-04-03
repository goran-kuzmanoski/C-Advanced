using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_Shop.Enums;

namespace PC_Shop.Classes
{
    public class Configuration
    {
        public Colors BoxColor { get; set; }
        private int Discount { get; set; }
        public string Name { get; set; }
        public Dictionary<Module, int> Modules { get; set; }
        public Dictionary<Part, int> Parts { get; set; }

        public Configuration(Colors color)

        {
            this.BoxColor = color;
            this.Modules = new Dictionary<Module, int>();
            this.Parts = new Dictionary<Part, int>();
        }

        public void AddModuleToProduct(Module p1, int quantity)
        {
            Modules.Add(p1, quantity);
        }
        public void AddPartToProduct(Part p1, int quantity)
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
            foreach (var p in Modules)
            {

                result+=p.Key.GetPrice() * p.Value;
            }

            return result;
        }
        public double GetPriceWithDiscount()
        {
            return GetPrice() - (GetPrice() * Discount / 100);
        }
    }
}
