using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Multilevel
{
    class A
    {
        public void welcome()
        {
            Console.WriteLine("Welcome to C#");
        }
    }
    class B:A
    {
        public void Hello()
        {
            Console.WriteLine("Hello Sir");
        }
    }
    class C:B
    {
        public void Hru()
        {
            Console.WriteLine("How Are You");
        }
    }
    class Multilevel
    {
        static void Main(string[] args)
        {
            C dev = new C();
            dev.welcome();
            dev.Hello();
            dev.Hru();
            Console.ReadLine();
        }
    }
}
