using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public abstract class Animal
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (value < 175 && value > 0)
                {
                    this._age = value;
                }
            }
        }
        public string Color { get; set; }
        public abstract void Print();

    }
}
