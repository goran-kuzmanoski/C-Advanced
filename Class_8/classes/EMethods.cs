using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8.classes
{
    public static class EMethods // extension methods are written in static class
    {
        // all extension methods are static
        public static string FirstLetter(this string someString) // Extension method first parameter must be written with this, that parameter is the item that we are calling the extension method on
        {
            return someString.Substring(0, 1);
            // 
        }
        // string name = "Bob"; -> name.FirstLetter();
        public static char LastLetter(this string somestring)
        {
            return somestring.ToCharArray().LastOrDefault();
        }
        public static bool isTrue(this int x)
        {
            if (x % 2 == 0) { return true; }
            else { return false; }
        }
      
        public static List<T> FirstInt<T>(this List<T> list, int n)
        {
            return list.Take(n).ToList();
        }
    }
}
