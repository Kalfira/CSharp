using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Top: ");
                int top = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Bottom: ");
                int bottom = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Program.Divide(top, bottom));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
