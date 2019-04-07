using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class BMW : Auto
    {
        //public override string Model { get; set; }
        //public override Manufacturer Manufacturer { get; set; }
        //public override AutoType AutoType { get; set; }
        //public override int Doors { get; set; }
        //public override Gas Gas { get; set; }
        //public override double Consumption { get; set; }
        //public override int Price { get; set; }
        public bool SunRoof { get; set; }

        public BMW(string model, bool sunroof, AutoType autoType, Gas gas, int doors, double consumption, int price)
        {
            this.Model = model;
            this.Manufacturer = Manufacturer.BMW;
            this.SunRoof = sunroof;
            this.AutoType = autoType;
            this.Gas = gas;
            this.Doors = doors;
            this.Consumption = consumption;
            this.Price = price;

        }
        public override string PrintCharacteristics()
        {
            if (SunRoof == true)
            {
                return base.PrintCharacteristics() + ", Auto has sunroof";
            }
            else
            {
                return base.PrintCharacteristics() + ", Auto has no sunroof";
            }
        }
    }
}
