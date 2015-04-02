using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose color: B for blue, or R for red.");
            string color = Console.ReadLine();
            if (color == "B")
            {
                Console.ForegroundColor = System.ConsoleColor.Blue;
            }
            if (color == "R")
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            Console.WriteLine("Enter value whose absolute value you wish to find:");
            Console.WriteLine("Enter 0 to exit");
            double x = double.Parse(Console.ReadLine());
            while (x != 0)
            {
                Console.WriteLine("The absolute value of your number is {0}", Math.Abs(x));
                Console.WriteLine("Enter value whose absolute value you wish to find:");
                Console.WriteLine("Enter 0 to exit");
                x = double.Parse(Console.ReadLine());
            }
        }
    }
}
