using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public class Bird:Animal
    {
        public bool isWild { get; set; }
        public void FlySouth()
        {
            if (isWild) { Console.WriteLine($"Bird \"{Name}\" is flying south "); }
            else { Console.WriteLine($"Bird \"{Name}\" is domesticated bird "); }
        }
        public Bird(bool wild, string name, int age, string color) : base()
        {
            this.isWild = wild;
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }
        public override void Print()
        {
            Console.WriteLine($"Is wild:{isWild}, name:{Name}, age={Age}, color:{Color}");
        }
    }
}
