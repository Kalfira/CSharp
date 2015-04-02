using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {

        private string whatever;

        public Program(string s)
        {
            this.whatever = s;
        }

        public static Program operator +(Program s1, Program s2)
        {
            return new Program(s1.whatever + s2.whatever+"Some other text");
        }

        public override string ToString()
        {
            return this.whatever;
        }

        static void Main(string[] args)
        {
            Program newprog1 = new Program("Hello, ");
            Program newprog2 = new Program("World!");
            Program createdProg = newprog1 + newprog2;
            Console.WriteLine(createdProg.ToString());
            Console.ReadKey();
        }
    }
}
