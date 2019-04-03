using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Trainer:Person
    {
        public Trainer(string firstname,
              string lastname,
              string username,
              string password
            )
              : base(firstname, lastname, username, password, Role.Trainer)
        {

        }
    }
}
