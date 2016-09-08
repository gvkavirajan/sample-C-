using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_loop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is while loop");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                Console.ReadLine();

            }
        }
    }
}