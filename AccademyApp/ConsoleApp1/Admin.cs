using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin : Person
    {
        public Admin(string firstname,
              string lastname,
              string username,
              string password
            )
              : base(firstname, lastname, username, password, Role.Admin)
        {

        }
    }
}
