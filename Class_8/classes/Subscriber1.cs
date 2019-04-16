using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public class Subscriber1
    {
        public void Subscribe1Process(string message)
        {

            Console.WriteLine($"Subscriber 1 received this message: {message} throught SMS");
        }
    }
}
