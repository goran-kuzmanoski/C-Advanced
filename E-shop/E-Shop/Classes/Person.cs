using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Classes
{
    public class Person
    {
        public string Name { get; set; }
        private string Password { get;}
        public List<Product> ShoppingCart { get; set; }
        public Person(string name, string pass)
        {
            Name = name;
            Password = pass;
            ShoppingCart =null;
        }


        public void CreateNewOrder(Product xxx)
        {
            ShoppingCart.Add(xxx);

        }

        public bool ValidPassword(string password)
        {
            return Password == password;
        }
    }
}
