using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public class Dog:Animal
    {
        public string Race { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark Bark");
        }
        public Dog(string race,string name, int age, string color) :base()
        {
            this.Race = race;
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }
        public override void Print()
        {
            Console.WriteLine($"Race:{Race}, name:{Name}, age={Age}, color:{Color}");
        }
    }
}
