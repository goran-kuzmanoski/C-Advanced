using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    abstract public class Auto
    {
        public  AutoType AutoType { get; set; }
        public  Manufacturer Manufacturer { get; set; }
        public  string Model { get; set; }
        public  Gas Gas { get; set; }
        public  int Doors { get; set; }
        public  double Consumption { get; set; }
        public  int Price { get; set; }

        public virtual string PrintCharacteristics()
        {
            return ($" Model:{this.Model} Manufacturer:{this.Manufacturer}, Gas:{this.Gas} ,Auto type={this.AutoType} , Price: {"$"+this.Price}");
        }
    }
}
