using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class calculator
    {
        public calculator() //constructor
        {
            Console.WriteLine("This is the code that runs when we make an instance of our class.");
        }

        public void yoMama()
        {
            Console.WriteLine("What is your momma so?");
            string a = Console.ReadLine();
            Console.WriteLine("Yo mama so {0}", a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            calculator calc;
            calc = new calculator();
            calc.yoMama();
            Console.Read();
        }
    }
}
