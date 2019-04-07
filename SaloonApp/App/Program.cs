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
            Saloon saloon_Audi = new Saloon("Boul Jane Sandaski BB", autos1);

            //saloon_Audi.Buy(19000, 36000);

            List<Auto> autos2 = new List<Auto>()
            {
            new BMW("M5",true,AutoType.travel,Gas.petrol,5,8,27000),
            new BMW("M3",false,AutoType.travel,Gas.diesel,5,6.5,22000),
            new BMW("X6",true,AutoType.cargo,Gas.petrol,5,8.2,35000),
            };
            Saloon saloon_BMW = new Saloon("Krste misirkov", autos2);
            //saloon_BMW.Buy(18000, 22000);

            List<Auto> autos3 = new List<Auto>()
            {
                new Opel("Zafira","Germany",AutoType.travel,Gas.diesel,5,5.7,19000),
                new Opel("Insignia","USA",AutoType.cargo,Gas.petrol,3,7.5,21500)
            };
            Saloon saloon_Opel = new Saloon("Skopje", autos3);

            List<Saloon> saloons = new List<Saloon> { saloon_Audi, saloon_BMW, saloon_Opel };
            while (true)
            {

                Console.WriteLine("Welcome to autoApp Macedonia");
                int min;
                while (true)
                {
                    Console.WriteLine("Please enter the minimum willing to spend on new auto");

                    bool minParse = int.TryParse(Console.ReadLine(), out min);
                    if (minParse) break;
                }
                int max;
                while (true)
                {
                    Console.WriteLine("Now enter the maximum willing to spend on new auto");
                    bool maxParse = int.TryParse(Console.ReadLine(), out max);
                    if (maxParse&&max>min) break;
                }
                while (true)
                {
                    Console.WriteLine("Please choose a saloon to see it`s cars in the desired range");
                    Console.WriteLine("1. Saloon Audi");
                    Console.WriteLine("2. Saloon BMW");
                    Console.WriteLine("3. Saloon Opel");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        saloon_Audi.Buy(min, max);
                        break;
                    }
                    else if (userChoice == "2")
                    {
                        saloon_BMW.Buy(min, max);
                        break;
                    }
                    else if (userChoice == "3")
                    {
                        saloon_Opel.Buy(min, max);
                        break;
                    }
                    else 
                    {
                        continue;
                    }
                    //switch (userChoice)
                    //{
                    //    case "1":
                    //        saloon_Audi.Buy(min, max);
                    //        break;
                    //    case "2":
                    //        saloon_BMW.Buy(min, max);
                    //        break;
                    //    case "3":
                    //        saloon_Opel.Buy(min, max);
                    //        break;
                    //    default:
                    //        Console.WriteLine("No such saloon please try again");
                    //        break;
                    //}
                }
                Console.WriteLine($"-----------------------");
                Console.WriteLine($"Do you want exit Y/N");
                string studentlogout = Console.ReadLine().ToLower();
                if (studentlogout == "y")
                {
                    Console.WriteLine("Thank you for using autoApp Macedonia");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
