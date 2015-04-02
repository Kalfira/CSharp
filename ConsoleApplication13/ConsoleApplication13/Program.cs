using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class PerimFinder
    {
        private int lengthofside; private int numberofsides;

        public PerimFinder(int length, int n)
        {
            this.lengthofside = length; this.numberofsides = n;
        }

        public static int operator +(PerimFinder s1, PerimFinder s2)
        {
            return s1.numberofsides * s1.lengthofside + s2.lengthofside * s2.numberofsides;
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo conkey;
            int x; int y; int xnumberofsides; int ynumberofsides;
            do
            {
                Console.WriteLine("Enter the first side length");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of sides for this shape");
                xnumberofsides = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second side length");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of sides for this shape");
                ynumberofsides = int.Parse(Console.ReadLine());

                PerimFinder newperim1 = new PerimFinder(x, xnumberofsides);
                PerimFinder newperim2 = new PerimFinder(y, ynumberofsides);
                Console.WriteLine(newperim1 + newperim2);
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }
    }
}
