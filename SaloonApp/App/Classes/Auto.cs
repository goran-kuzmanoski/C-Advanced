using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    abstract public class Auto
    {
        public abstract AutoType AutoType { get; set; }
        public abstract Manufacturer Manufacturer { get; set; }
        public abstract string Model { get; set; }
        public abstract Gas Gas { get; set; }
        public abstract int Doors { get; set; }
        public abstract double Consumption { get; set; }
        public abstract int Price { get; set; }

        public virtual string PrintCharacteristics()
        {
            return ($" Model:{this.Model} Manufacturer:{this.Manufacturer}, Gas:{this.Gas} ,Auto type={this.AutoType} , Price: {"$"+this.Price}");
        }
    }
}
