using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Person
    {
        public string name;
        public string ssn;
        public Person(string fullname, string social)
        {
            this.name = fullname;
            this.ssn = social;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("John Smith", "8675309");
            Person per2 = new Person("Bubba Smith", "111111");
            Console.WriteLine(per1.name);
            Console.WriteLine(per2.name);
            Console.Read();

        }
    }
}
