using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Classes;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos1 = new List<Auto>()
            {
            new Audi("A3","Red",AutoType.travel,Gas.diesel,3,5.5,18000),
            new Audi("Q5","Silver", AutoType.travel, Gas.petrol, 5, 7.5, 25000),
            new Audi("Q7","Black", AutoType.cargo, Gas.diesel, 2, 7.5, 35000)
            };
            Saloon saloonAudi = new Saloon("Boul Jane Sandaski BB", autos1);

            saloonAudi.Buy(19000, 36000);

            List<Auto> autos2 = new List<Auto>()
            {
            new BMW("M5",true,AutoType.travel,Gas.petrol,5,8,27000),
            new BMW("M3",false,AutoType.travel,Gas.diesel,5,6.5,22000),
            new BMW("X6",true,AutoType.cargo,Gas.petrol,5,8.2,35000),
            };
            Saloon saloonBMW = new Saloon("Krste misirkov", autos2);
            saloonBMW.Buy(18000, 22000);
        }
    }
}
