using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Destructor
{
    class A
    {
        public A()
        {
            Console.WriteLine("A created");
        }
        ~A()
        {
            Console.WriteLine("A Destroyed");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("B created");
        }

        public B(string s)
        {
            Console.WriteLine("B with argument");
        }

        ~B()
        {
            Console.WriteLine("B Destroyed");
        }
    }
    class C:B
    {
        public C(int a)
        {
            Console.WriteLine("C created");
        }

        ~C()
        {
            Console.WriteLine("C Destroyed");
        }
    }
    class sample
    {
        static void Main(string[] args)
        {
            C obj = new C(5);
            Console.WriteLine("object Created");
            Console.WriteLine("press enter destroyed the object");
            Console.ReadLine();
        }
    }
}
