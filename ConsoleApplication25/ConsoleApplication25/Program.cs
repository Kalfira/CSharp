using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter top");
                int top = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter bottom: ");
                int bottom = Int32.Parse(Console.ReadLine());
                int quot = top / bottom;
                Console.WriteLine(quot);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }
}
