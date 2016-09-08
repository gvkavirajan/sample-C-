using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class First
    {
        ~First()
        {
            Console.WriteLine("First destructor called");
        }
    }
    class Second:First
    {
        ~Second()
        {
            Console.WriteLine("Second destructor called");
        }
    }
    class Third:Second
    {
        ~Third()
        {
            Console.WriteLine("Third destructor called");
        }
    }
    class TestDestructors
    {
        static void Main()
        {
            Third t = new Third();
        }
    }
}
