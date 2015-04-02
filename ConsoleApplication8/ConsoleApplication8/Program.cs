using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Person
    {
        private string name;
        private string ssn;
        public string Social
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }
        public string FullName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            per1.FullName = "John Smith";
            per1.Social = "111-11-111";
            Console.WriteLine(per1.FullName + " has their SSN given by " + per1.Social);
            Console.Read();
        }
    }
}
