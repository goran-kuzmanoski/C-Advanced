using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public class MyGenericClass
    {
        public void Print<T>(List<T> prop)
        {
            foreach (var item in prop)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintAnimals<T>(List<T> animals)
            where T : Animal
        {
            foreach (var animal in animals)
            {
                animal.Print();
            }

        }
    }
}
