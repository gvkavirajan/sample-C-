using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_using_different_method_name
{
    class A
    {
        public void welcome()
        {
            Console.WriteLine("welcome to ascendas");
        }
    }
    class B:A
    {
        public void welcome1()
        {
            Console.WriteLine("welcome to ofs");
        }
    }
    class C:B
    {
        public void welcome2()
        {
            Console.WriteLine("welcome to c#");
        }
    }
    class sample
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.welcome();
            obj.welcome1();
            obj.welcome2();
            Console.ReadLine();
        }
    }
}
