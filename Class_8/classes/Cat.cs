using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public class Cat : Animal
    {
        public bool isLazy { get; set; }
        public void meow()
        {
            Console.WriteLine("MEWOW MEOW MEOW");
        }
        public Cat(bool lazy, string name, int age, string color) : base()
        {
            this.isLazy = lazy;
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }


        public override void Print()
        {
            Console.WriteLine($"Lazy:{isLazy}, name:{Name}, age={Age}, color:{Color}");
        }
    }
}
