using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Hybrid
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
        public void Hello()
        {
            Console.WriteLine("Hello Sir");
        }
    }
    class C
    {
        public void Hru()
        {
            Console.WriteLine("How are You");
        }
    }
    class D:C,B
    {
        public void Wdng()
        {
            Console.WriteLine("what Doing");
        }
    }
    class mainProgram
    {
        static void Main(string[] args)
        {
            D dev;
            dev.
            Console.ReadLine();
        }
    }
}
