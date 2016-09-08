using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Hirerical
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
    class C:A
    {
        public void Hru()
        {
            Console.WriteLine("How Are You");
        }
    }
    class Hirerical
    {
        static void Main(string[] args)
        {
            B dev1 = new B();
            dev1.welcome();
            dev1.Hello();
            C dev2 = new C();
            dev2.welcome();
            dev2.Hru();
            Console.ReadLine();
         }
    }
}
