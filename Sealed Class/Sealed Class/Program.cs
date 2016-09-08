using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
        //sealed class Base
        class Base
    {
        public void disp()
        {
            Console.WriteLine("Base Class");
        }
        class Derived : Base
        {
            public void disp1()
            {
                Console.WriteLine("Derived class");
            }
            static void Main(string[] args)
            {
                Base b = new Base();
                b.disp();
                Console.ReadLine();
            }
        }
    }
}
