using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is an example of a string that " +
                "spans multiple lines";
            Console.WriteLine("The string is {0}", str);
            string part = str.Substring(1, 5);
            Console.WriteLine("The part is {0}", part);
            string mid = str.ToLower();
            Console.WriteLine("The string starts with This: {0}", mid.StartsWith("this"));
            Console.WriteLine("The first i is located at {0}", str.IndexOf("i"));
            Console.Read();
        }
    }
}
