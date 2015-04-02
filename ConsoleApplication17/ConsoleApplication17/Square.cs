using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Square : Rectangle
    {
        static void Main(string[] args)
        {
            Square mysqr = new Square();
            double sqrarea = mysqr.Area(5.6, 5.6);
            Console.WriteLine("The area is {0}", sqrarea);
            Console.Read();
        }
    }
}
