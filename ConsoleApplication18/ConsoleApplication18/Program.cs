using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Parent
    {
        public static int x = 10;
        protected static int y = 12;
        private static int z = 25;
        public void GetX()
        {
            Console.WriteLine(x);
        }
    }

    class Child : Parent
    {
        public static void Print()
        {
            Console.WriteLine(y);
        }
    }

    class NotConnected
    {
        public static void Print()
        {
            Console.WriteLine(Parent.x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent thing = new Parent();
            Parent.x = 7;
            Console.WriteLine(Parent.x);
            thing.GetX();
            Console.Read();
        }
    }
}
