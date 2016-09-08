using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace do_while_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is do while loop");
          
                int i=0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                    while (i < 8);
                Console.ReadLine();
                
        }
    }
}
