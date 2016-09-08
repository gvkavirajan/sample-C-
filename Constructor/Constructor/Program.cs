using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class welcome
    {
        public welcome()
        {
            Console.WriteLine("welcome to Default constructor");
        }
        public welcome(string name)
        {
            Console.WriteLine("\n\nwelcome to parametrized constructor");
            Console.WriteLine("welcome to constuctor sample, by {0}", name);
        }
        static void Main(string[] args)
        {
            welcome obj = new welcome();
            welcome pobj = new welcome("Muthukumar");
            Console.ReadLine();
        }
    }
}
