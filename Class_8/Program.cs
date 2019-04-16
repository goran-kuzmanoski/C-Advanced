using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_8.classes;

namespace Class_8
{
    class Program
    {
        public delegate bool NewDelegate(string s1, string s2);

        static void Main(string[] args)
        {

            List<Dog> dogs = new List<Dog> { new Dog("retriever", "Sarko", 7, "Brown"),
                                             new Dog("haskey", "Mailo", 2, "White"),
                                             new Dog("retriever", "Leo", 3, "Black") };
            List<Cat> cats = new List<Cat> { new Cat(true,"Garfield",3,"Brown"),
                                             new Cat(false,"Tom",2,"Black"),
                                             new Cat(false,"Kitty",3,"white")};
            List<Bird> birds = new List<Bird> { new Bird(false,"Cavka",1,"Black"),
                                                new Bird(false,"Kokoska",1,"Brown"),
                                                new Bird(true,"Lastovica",2,"Black")};
            var retriever = dogs.Where(x => x.Race == "retriever");
            foreach(Dog retrieve in retriever)
            {
                Console.WriteLine(retrieve.Name);
            }

            var lastLazyCat = cats.Last(x => x.isLazy == true);
            Console.WriteLine(lastLazyCat.Name);

            var wildBirdsYoungerThan3 = birds.Where(x => x.isWild == true&& x.Age < 3).OrderBy(x => x.Name).ToList();
            foreach (Bird bird in wildBirdsYoungerThan3)
            {
                Console.WriteLine($"Bird younger than 3 {bird.Name}");
            }
            var name = "Goran";
            Console.WriteLine(name.FirstLetter());
            Console.WriteLine(name.LastLetter());

            var c=dogs.FirstInt(9);
            foreach (var item in c)
            {
                Console.WriteLine(item.Name);
            }
            List<int> int322 = new List<int> { 3, 6, 2, 8, 2, 15, 16, 18 };
            List<string> strings = new List<string> { "Krste", "Dragan", "Petko" };

            MyGenericClass generici = new MyGenericClass();
            generici.Print(int322);
            generici.Print(strings);
            generici.PrintAnimals(dogs);

            string str1 = "Gorana";
            string str2 = "blabla";
            StringMagic(str1, str2, (x, y) =>
            {
                if (x.Length > y.Length)
                {
                    return true;
                }
                return false;
            });
            StringMagic(str1, str2, (x, y) =>
            {
                if (x.ToCharArray().First() == y.ToCharArray().First())
                {
                    return true;
                }
                return false;
            });
            StringMagic(str1, str2, (x, y) =>
            {
                if (x.ToCharArray().Last() == y.ToCharArray().Last())
                {
                    return true;
                }
                return false;
            });


            Publisher p = new Publisher();
            Subscriber1 s1 = new Subscriber1();
            Subscriber2 s2 = new Subscriber2();
            Subscriber3 s3 = new Subscriber3();

            p.EventHandler += s1.Subscribe1Process;
            p.EventHandler += s2.Subscribe2Process;
            p.EventHandler += s3.Subscribe3Process;

            p.ComposeMessage("Dragan", 1, "DECKI UCETE");
            Console.ReadLine();



        }
        public static void StringMagic(string str1, string str2, NewDelegate funk)
        {
            var result = funk(str1, str2);
            Console.WriteLine(str1 + " " + str2 + " " + result.ToString());
        }
                                      
    }
}
