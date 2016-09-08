using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Single
{
    class A
    {
        public void welcome()
        {
            Console.WriteLine("Welcome to c#");
        }
    }
    class B:A
    {
        public void hello()
        {
            Console.WriteLine("Hello Sir");
        }
    }
    class single
    {
        public static void Main(string[] args)
        {
            B dev = new B();
            dev.welcome();
            dev.hello();
            Console.ReadLine();
        }
    }
}

