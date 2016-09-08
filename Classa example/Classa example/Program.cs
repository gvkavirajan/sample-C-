using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classa_example
{
    class Box
    {
        public void open()
        {
            Console.WriteLine("Box opened");
        }

        static void Main(string[] args)
        {
            Box b = new Box();
            b.open();
            Console.ReadLine();
        }
    }
}
