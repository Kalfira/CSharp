using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{

      class Quad
      {
          public Quad()
          {
              Console.WriteLine("I'm a quad!");
          }
          public virtual int Perimeter(int width, int length)
          {
              return 2 * width + 2 * length;
          }
      }

      class Square : Quad
      {
          public override int Perimeter(int width, int length)
          {
              return 4 * width;
          }
      }

    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square();
            int w = 2; int l = 2;
            Console.WriteLine("The perimeter of our shape is {0}.", mySquare.Perimeter(w, l));
            Console.ReadLine();
        }
    }
}
