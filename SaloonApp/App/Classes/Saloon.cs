using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
       public class Saloon
    {
        public string Address { get; set; }
        public List<Auto> Autos { get; set; }
        public Saloon(string address,List <Auto> autos)
        {
            this.Address = address;
            this.Autos = autos;

        }
        public void Buy(int min,int max)
        {
            Console.WriteLine($"Withhin this range {min} - {max}  you can buy:");
            foreach (Auto Auto in Autos)
            {
                if (Auto.Manufacturer == Manufacturer.Audi)
                {
                    Audi auto = (Audi)Auto;
                    if (auto.Price <= max && auto.Price >= min)
                    {
                        Console.Write(auto.PrintCharacteristics()+"\n");
                    }
                }
                if (Auto.Manufacturer == Manufacturer.BMW)
                {
                    BMW auto = (BMW)Auto;
                    if (auto.Price <= max && auto.Price >= min)
                    {
                        Console.Write(auto.PrintCharacteristics() + "\n");
                    }
                }
                if (Auto.Manufacturer == Manufacturer.Opel)
                {
                    Opel auto = (Opel)Auto;
                    if (auto.Price <= max && auto.Price >= min)
                    {
                        Console.Write(auto.PrintCharacteristics() + "\n");
                    }
                }

            }
        }
    }
}
