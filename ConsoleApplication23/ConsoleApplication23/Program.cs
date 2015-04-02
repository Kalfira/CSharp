using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        class Calculator
        {
            public Calculator()
            {
                Console.WriteLine("I'm a lazy calculator. I do only division");
            }
            public double Divide(double x, double y)
            {
                if (y != 0.0)
                {
                    return x / y;
                }
                else
                {
                    return 0.0;
                }
            }
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x = 4; int y = 10;
            Console.WriteLine("The result of dividing {0} and {1} is {2}", x, y, calc.Divide(x, y));
            Console.Read();
        }
    }
}
