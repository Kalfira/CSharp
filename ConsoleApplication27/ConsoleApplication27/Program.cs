using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{

    class Person
    {
        private string fullname;
        public Person(string name)
        {
            this.fullname = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("John");
            Person per2 = per1;
            Person per3 = new Person("John");
            Console.WriteLine("per1 and per2 are the same: {0}", per1.Equals(per2));
            Console.WriteLine("per1 and per2 are the same: {0}", Object.ReferenceEquals(per1, per2));
            Console.WriteLine("per1 and per3 are the same: {0}", per1.Equals(per3));
            Console.ReadLine();
        }
    }
}
