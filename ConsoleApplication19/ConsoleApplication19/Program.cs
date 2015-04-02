using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication19
{
    public class sample
    {
        Stopwatch timer;
        public sample()
        {
            timer = Stopwatch.StartNew();
            Console.WriteLine("This code runs when the object is constructed");
        }
        public void HowLong()
        {
            Console.WriteLine("{0} has lived for {1}.", this, timer.Elapsed);
            Console.ReadLine();
        }
        ~sample()
        {
            this.HowLong();
            Console.WriteLine("This code runs when the object is destroyed");
            Console.Read();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            sample samp = new sample();
            Console.ReadLine();
        }
    }
}
