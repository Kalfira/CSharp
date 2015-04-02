using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;

namespace ConsoleApplication111
{

    interface ICanBeUsedAsAChair //declare interface
    {
        void SittingMessage();
    }
    class MilkCrate : ICanBeUsedAsAChair
    {
        public MilkCrate()
        {
            Console.WriteLine("I'm a milk crate.");
        }
        public void SittingMessage()
        {
            Console.WriteLine("I'm a crate being used as a chair..hard work!");
        }
    }
    class SharpThing : ICanBeUsedAsAChair
    {
        public SharpThing()
        {
            Console.WriteLine("I'm a sharp thing!");
        }
        public void SittingMessage()
        {
            Console.WriteLine("FUCKING OW!");
        }
    }

    class Program
    {
        public static void CanSitOn(ICanBeUsedAsAChair fakeChair)
        {
            fakeChair.SittingMessage();
        }
        static void Main(string[] args)
        {
            MilkCrate milkCrate = new MilkCrate();
            SharpThing sharpThing = new SharpThing();
            Program.CanSitOn(milkCrate);
            Console.ReadLine();
            Program.CanSitOn(sharpThing);
            Console.ReadLine();
        }

    }
}