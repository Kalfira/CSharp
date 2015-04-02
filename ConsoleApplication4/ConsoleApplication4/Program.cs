using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
     class calculator
     {
         public calculator()
         {
             Console.WriteLine("We're making a calculator object...");
         }
         public double Add(double x, double y)//This fuction accepsts two double types and returns another double type
         {
             return x + y;
         }
         public double Subtract(double x, double y)//This fuction accepsts two double types and returns another double type
         {
             return x - y;
         }
         public double Multiply(double x, double y)//This fuction accepsts two double types and returns another double type
         {
             return x * y;
         }
         public double Division(double x, double y)//This fuction accepsts two double types and returns another double type
         {
             return x / y;
         }

     }

    class Program
    {
        static void Main(string[] args)
        {   
            calculator calc = new calculator();
            double x = 4;
            double y = 6;
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, calc.Add(x,y));
            Console.Read();
        }
    }
}
