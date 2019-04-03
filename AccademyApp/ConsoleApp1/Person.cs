using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        private string Password { get; }

        public Person(string firstname, string lastname, string username, string password, Role role)
        {
            Firstname = firstname;
            Lastname = lastname;
            Role = role;
            Username = username;
            Password = password;

        }
        public bool ValidPassword(string password)
        {
            return Password == password;
        }
    }
}
