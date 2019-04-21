using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Classes;

namespace E_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> buyers = new List<Person>()
            {
                new Person("Goran","xxx"),
            };
            List<Product> tinexProducts = new List<Product>()
            {
                new Product(1,"Zlaten dab",0.5,100,42),
                new Product(2,"Zlaten dab",1.5,100,97),
                new Product(3,"Krali Marko",1.5,100,75),
                new Product(4,"Krali Marko-glass",0.5,100,37),
                new Product(5,"Skopsko",0.5,100,45),
                new Product(6,"Skopsko",1.5,50,105),
            };
            List<Product> kamProducts = new List<Product>()
            {
                new Product(1,"Airwais extreme",0.03,100,21),
                new Product(2,"Orbit watermelon",0.03,100,21),
                new Product(3,"Bademi",0.1,50,54),
                new Product(4,"Fstaci",0.15,50,74),
                new Product(5,"Skopsko",0.5,100,42),
                new Product(6,"Bieno Sirenje",1,10,272),
            };
            List<Product> ramstoreProducts = new List<Product>()
            {
                new Product(1,"Piperki luti",1,10,140),
                new Product(2,"Domati rozovi",1,20,150),
                new Product(3,"Domati crveni",1,10,120),
                new Product(4,"Limon",1,10,57),
                new Product(5,"Skopsko",1.5,100,105),
                new Product(6,"Krastavici",1,20,54)
            };
            List<Vendor> vendors = new List<Vendor>()
            {
                new Vendor("Tinex",tinexProducts),
                new Vendor("KAM",kamProducts),
                new Vendor("Ramstore",ramstoreProducts),
            };

            Person User;
            while (true)
            {
                Console.WriteLine("Enter username");
                string inputUsername = Console.ReadLine();
                User = buyers.Where(x => x.Name == inputUsername).FirstOrDefault();
                if (User == null)
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                Console.WriteLine("Enter Password");
                string inputPassword = Console.ReadLine();
                if (User.ValidPassword(inputPassword))
                {
                    Console.WriteLine("Correct password");
                    break;
                }
                else
                {

                    continue;
                }
            }
            Console.WriteLine("Please choose one of the following action");
            Console.WriteLine("1. Show the list of vendors");
            Console.WriteLine("2. Create new order");
            Console.WriteLine("3. Show your shopping cart");
            Console.WriteLine("4. Remove item from the cart");
            Console.WriteLine("5. Pay and exit");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("Aviable vendors:");
                Console.WriteLine($"{vendors.Select(x=>x.Name)}");
                
            }
            //code here
        }
    }
}
