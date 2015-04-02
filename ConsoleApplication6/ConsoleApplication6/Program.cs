using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("I can take you places!");
        }
    }

    class RaceCar : Vehicle // racecar is a kind of vehicle
    {
        public RaceCar():base()
        {
            Console.WriteLine("I can take you places... very fast.");
        }
    }

    class MiniVan:Vehicle //minivan is a kind of vehicle
    {
        public MiniVan() : base()
        {
            Console.WriteLine("I can take you places... with 25 kids inside!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RaceCar newRaceCar = new RaceCar();
            MiniVan newMiniVan = new MiniVan();
            Console.Read();
        }
    }
}
