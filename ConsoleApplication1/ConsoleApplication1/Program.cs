using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            ChangeValue(out x);

            Console.WriteLine("X: {0}", x);
            Console.ReadLine();
        }

        private static void ChangeValue(out int x)
        {
            x = 10;
        }
    }
}
