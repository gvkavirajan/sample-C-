using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bool__keyword_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool val = true;
            if (val)
            {
                Console.WriteLine(val == true);
            }
            val = !val;
            if (!val)
            {
                Console.WriteLine(val == false);
                Console.ReadLine();
                Console.Read();
            }

                    
        }
    }
}
