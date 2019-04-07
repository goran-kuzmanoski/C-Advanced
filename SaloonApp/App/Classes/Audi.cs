using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Audi : Auto
    {
        //public override string Model { get; set; }
        //public override Manufacturer Manufacturer { get; set; }
        //public override AutoType AutoType { get; set; }
        //public override int Doors { get; set; }
        //public override Gas Gas { get; set; }
        //public override double Consumption { get; set; }
        //public override int Price { get; set; }
        public string Color { get; set; }

        public Audi(string model,string color, AutoType autoType,Gas gas,int doors,double consumption,int price)
        {
            this.Model = model;
            this.Manufacturer = Manufacturer.Audi;
            this.Color = color;
            this.AutoType = autoType;
            this.Gas = gas;
            this.Doors = doors;
            this.Consumption = consumption;
            this.Price = price;
            
        }
        public string PrintColor()
        {
            return Color;
        }

        public override string PrintCharacteristics()
        {
            return (base.PrintCharacteristics() + ", Color:"+ PrintColor());
        }


    }
}
